using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            if (!IsPasswordResetLinkValid())
            {
                Label_msg.ForeColor = System.Drawing.Color.Red;
                Label_msg.Text = "Password Reset link has expired or is invalid";
            }
        }
    }


    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        if (ChangeUserPassword())
        {
            Label_msg.ForeColor = System.Drawing.Color.Green;
            Label_msg.Text = "Password Changed Successfully!";
            div_changePassword_box.Visible = false;
            
        }
        else
        {
            Label_msg.ForeColor = System.Drawing.Color.Red;
            Label_msg.Text = "Password Reset link has expired or is invalid";
        }
    }

    private bool ExecuteSP(string SPName, List<SqlParameter> SPParameters)
    {
        string CS = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand(SPName, con);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parameter in SPParameters)
            {
                cmd.Parameters.Add(parameter);
            }

            con.Open();
            return Convert.ToBoolean(cmd.ExecuteScalar());
        }
    }

    private bool IsPasswordResetLinkValid()
    {
        List<SqlParameter> paramList = new List<SqlParameter>()
        {
            new SqlParameter()
            {
                ParameterName = "@guid",
                Value = Request.QueryString["uid"]
            }
        };

        return ExecuteSP("Is_Password_Reset_Link_Valid", paramList);
    }

    private bool ChangeUserPassword()
    {
        List<SqlParameter> paramList = new List<SqlParameter>()
        {
            new SqlParameter()
            {
                ParameterName = "@guid",
                Value = Request.QueryString["uid"]
            },
            new SqlParameter()
            {
                ParameterName = "@Password",
                Value = FormsAuthentication.HashPasswordForStoringInConfigFile(reset_pwd.Value, "SHA1")
            }
        };
        return ExecuteSP("change_usr_password", paramList);
    }

}
