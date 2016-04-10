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

public partial class EMPLOYEE_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SetImageUrl();
        }
    }


    protected void Timer_Image_slider_Tick(object sender, EventArgs e)
    {
        SetImageUrl();
    }
    private void SetImageUrl()
    {
        Image1.Style.Add("border-radius", "5%");
        if (ViewState["ImageDisplayed"] == null)
        {
            Image1.ImageUrl = "~/Images/slide_show/1.jpg";
            ViewState["ImageDisplayed"] = 1;
            
        }
        else
        {
            
            int i = (int)ViewState["ImageDisplayed"];
            if (i == 8)
            {
                Image1.ImageUrl = "~/Images/slide_show/1.jpg";
                ViewState["ImageDisplayed"] = 1;
                
            }
            else
            {
                i++;
                Image1.ImageUrl = "~/Images/slide_show/" + i.ToString() + ".jpg";
                ViewState["ImageDisplayed"] = i;
                
            }
            
        }
    }
}
