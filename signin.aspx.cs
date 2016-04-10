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
using nsUser;


public partial class EMPLOYEE_signin : System.Web.UI.Page
{
    clsEmpPrp objPrp = new clsEmpPrp();
    clsEmp obj = new clsEmp();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (User.IsInRole("admin"))
        {
            Response.Redirect("~/ADMIN/home.aspx");
        }
        if (User.IsInRole("emp"))
        {
            Response.Redirect("~/EMPLOYEE/home.aspx");
        }
    }
    
  
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                Session["id"] = objPrp.Pemp_email = login_username.Value;
                objPrp.Pemp_password = login_password.Value;
                int chk_user = obj.usr_authentication(objPrp);
                if (chk_user == 1) //admin user
                {
                    FormsAuthenticationTicket tkt = new FormsAuthenticationTicket(1, objPrp.Pemp_email, DateTime.Now, DateTime.Now.AddMinutes(20), false, "admin", FormsAuthentication.FormsCookiePath);
                    string st = FormsAuthentication.Encrypt(tkt);
                    HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName, st);
                    Response.Cookies.Add(ck);
                    Response.Redirect("~/ADMIN/home.aspx");
                }
                else if (chk_user == 2) //emp or admin user
                {
                    FormsAuthenticationTicket tkt = new FormsAuthenticationTicket(1, objPrp.Pemp_email, DateTime.Now, DateTime.Now.AddMinutes(20), false, "emp", FormsAuthentication.FormsCookiePath);
                    string st = FormsAuthentication.Encrypt(tkt);
                    HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName, st);
                    Response.Cookies.Add(ck);
                    Response.Redirect("~/EMPLOYEE/home.aspx");
                }
                else if (chk_user == -1) //invalid user          
                {
                    Label_Error.Visible = true;
                    login_username.Style.Add("Border-Color", "red");
                    login_password.Style.Add("Border-Color", "red");
                }

            }
        }
        catch
        {
            //Response.Redirect("www.google.com");
        }
    }
}
