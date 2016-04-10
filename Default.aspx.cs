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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select avg(net_dl_speed) as download_speed, avg(net_ul_speed) as upload_speed, 'Early Morning' as time, '1' as sn from tb_net_speed where CONVERT(CHAR(5),date,108) >= '04:00' AND CONVERT(CHAR(5),date,108) < '07:59' and mac_ip='192.168.217.190'", con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        Chart1.DataSource = cmd.ExecuteReader();
        Chart1.DataBind();
        con.Close();
        cmd.Dispose();
    }
}
