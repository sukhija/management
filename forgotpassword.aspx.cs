using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRequestPwd_Click(object sender, EventArgs e)
    {
        string CS = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand("forgotPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("e_mail", SqlDbType.VarChar, 50).Value = login_username.Value;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["ReturnCode"]))
                {
                    SendPasswordResetEmail(dr["Name"].ToString(), login_username.Value, dr["UniqueId"].ToString());
                    Label_msg.Text = "An email with instructions to reset your password is sent to your registered email, Kindely check your Email.";
                    Label_msg.ForeColor = System.Drawing.Color.Green;
                    div_forgot_box.Visible = false;
                }
                else
                {
                    Label_msg.ForeColor = System.Drawing.Color.Red;
                    Label_msg.Text = "Username not found!";
                }
            }
        }
    }

    private void SendPasswordResetEmail(string UserName, string ToEmail, string UniqueId)
    {
        // MailMessage class is present is System.Net.Mail namespace
        MailMessage mailMessage = new MailMessage("developer.csio@gmail.com", ToEmail);


        // StringBuilder class is present in System.Text namespace
        StringBuilder sbEmailBody = new StringBuilder();
        sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
        sbEmailBody.Append("Please click on the following link to reset your password");
        sbEmailBody.Append("<br/>");
        sbEmailBody.Append("http://192.168.217.190/Changepassword.aspx?uid=" + UniqueId);
        sbEmailBody.Append("<br/><br/>");
        sbEmailBody.Append("<b>Regards,<br/>CSIO MIS</b><br />");


        sbEmailBody.Append("<span> &#169; 2015 Central Scientific Instruments Organisation, Sector 30, Chandigarh. This e-mail contains PRIVILEGED AND CONFIDENTIAL INFORMATION intended solely for the use of  the addressee(s). If you are not the intended recipient, please notify the sender by e-mail and delete the original message. Further, you are not to copy, disclose, or distribute this e-mail or its contents to any other person and any such actions are unlawful.<span/>");
        
        
        mailMessage.IsBodyHtml = true;

        mailMessage.Body = sbEmailBody.ToString();
        mailMessage.Subject = "Reset Your Password";
        SmtpClient smtpClient = new SmtpClient();
        smtpClient.EnableSsl = true;
        smtpClient.Send(mailMessage);
    }
}