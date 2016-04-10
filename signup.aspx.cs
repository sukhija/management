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
using System.Web.Script.Serialization;
using System.IO;
using System.Net;

public partial class _Default : System.Web.UI.Page
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
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (Validate())
            {
                if (FileUpload1.HasFile == true)
                {
                    string fileName = string.Empty;
                    string filePath = string.Empty;
                    fileName = FileUpload1.FileName.Substring(FileUpload1.FileName.LastIndexOf("."));
                    filePath = Server.MapPath("~/Profile_Pictures/" + Guid.NewGuid() + fileName);
                    FileUpload1.SaveAs(filePath);
                    int fileSize = FileUpload1.PostedFile.ContentLength;

                    if ((fileName.ToLower() == ".jpg" || fileName.ToLower() == ".jpeg" ||
                    fileName.ToLower() == ".bmp" || fileName.ToLower() == ".png" ||
                    fileName.ToLower() == ".gif") && (fileSize <= 2097152)) //----------------size<=2MB
                    {
                        objPrp.Pemp_f_name = TextBox1.Text;
                        objPrp.Pemp_l_name = TextBox2.Text;
                        objPrp.Pemp_email = TextBox3.Text;
                        objPrp.Pemp_password = TextBox4.Text;
                        objPrp.Pemp_address = TextBox5.Text;
                        objPrp.Pemp_c_number = TextBox6.Text;
                        objPrp.Pemp_e_number = TextBox7.Text;
                        string dob = Page.Request.Form["datepicker"];
                        objPrp.Pemp_dob = Convert.ToDateTime(Page.Request.Form["datepicker"]);
                        objPrp.Pemp_gender = DropDownList1.SelectedValue;
                        objPrp.Pemp_register_date = DateTime.Now;
                        objPrp.Pemp_picture_path = "../Profile_Pictures/" + filePath.Substring(filePath.LastIndexOf("\\") + 1);

                        int chk_user = obj.request_send(objPrp);
                        if (chk_user == -1)
                        {
                            signupalert.Visible = true;
                            Label2.Text = "Email Id Already Exists";
                        }
                        else
                        {
                            lblGoogleReCaptcha.Text = "valid recaptcha";
                            lblGoogleReCaptcha.ForeColor = System.Drawing.Color.Green;
                            clear_rec();
                            loginForm.Visible = false;
                            successMsg.Visible = true;
                        }
                    }
                    else
                    {
                        signupalert.Visible = true;
                        Label2.Text = "Only images with format .jpg, .bmp, .png, .gif are applicable";
                    }
                }
                else
                {
                    signupalert.Visible = true;
                    Label2.Text = "Please upload valid image file";
                }
            }
            else
            {
                lblGoogleReCaptcha.Text = "not valid recaptcha";
                lblGoogleReCaptcha.ForeColor = System.Drawing.Color.Red;
            }
            
        }
        else
        {

        }

    }
    public new bool Validate()
    {

        string Response = Request["g-recaptcha-response"];//Getting Response String Appned to Post Method

        bool Valid = false;
        //Request to Google Server
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(" https://www.google.com/recaptcha/api/siteverify?secret=6LfM3hITAAAAAMCc53fr2Mp6C-8Tp_hpW7bnsI8B&response=" + Response);
                                                                                                                        
        try
        {
            //Google recaptcha Responce 
            using (WebResponse wResponse = req.GetResponse())
            {

                using (StreamReader readStream = new StreamReader(wResponse.GetResponseStream()))
                {
                    string jsonResponse = readStream.ReadToEnd();

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    MyObject data = js.Deserialize<MyObject>(jsonResponse);// Deserialize Json 

                    Valid = Convert.ToBoolean(data.success);


                }
            }

            return Valid;

        }
        catch (WebException ex)
        {
            throw ex;
        }
    }


    public class MyObject
    {
        public string success { get; set; }
    }
    private void clear_rec()
    {
        //Page.Request.Form["tbusername"] = string.Empty;
        //Page.Request.Form["tbpassword"] = string.Empty;
        signupalert.Visible = false;
        Label1.Text = string.Empty;
        Label2.Text = string.Empty;
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        TextBox3.Text = string.Empty;
        TextBox4.Text = string.Empty;
        TextBox5.Text = string.Empty;
        TextBox6.Text = string.Empty;
        TextBox7.Text = string.Empty;
        //Page.Request.Form["datepicker"] = null;
        DropDownList1.SelectedIndex = -1;
        TextBox1.Focus();
    }

}
