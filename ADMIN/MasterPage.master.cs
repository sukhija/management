using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;
using nsUser;
using nsAdmin;
using System.Drawing;


public partial class ADMIN_MasterPage : System.Web.UI.MasterPage
{
    clsEmpPrp objEmpPrp;
    clsEmp objEmp;
    //clsSoftwarePrp objSoftwarePrp;
    //clsSoftware objSoftware;
    //clsHardwarePrp objHardwarePrp;
    //clsHardware objHardware;
    //clsMiscellaneousPrp objMiscellaneousPrp;
    //clsMiscellaneous objMiscellaneous;
    //clsStationaryPrp objStationaryPrp;
    //clsStationary objStationary;
    //int Gridview_Request_Row_Count;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        {
            gridview_request_bind();
            //gridview_notification_bind();

            
        }
        //------------------------------------count no of requests
    }
    public string P_Text
    {
        get
        {
            return Label1.Text;
        }
        set
        {
            Label1.Text = value;
        }
    }
    private void no_of_requests_on_badge()
    {
        no_of_requests.InnerText = Gridview_Request.Rows.Count.ToString();
       
        if (Convert.ToInt32(no_of_requests.InnerText) > 0)
        {
            no_of_requests.Style.Add("Color", "Red");
        }
    }
    //public void icons_color()
    //{
    //    Page.Request.Form.Set("Color", "Red");
    //    no_of_notifications.Style.Add("Color", "Red");
    //}
    

    //------------------------------------------------------REQUEST-MODULE----------------------------------------------------

    private void gridview_request_bind()
    {
        objEmp = new clsEmp();
        Gridview_Request.DataSource = objEmp.disp_request();
        Gridview_Request.DataBind();
        no_of_requests_on_badge();
        Free_Memory();
        
    }
    
    
    private void Free_Memory()
    {
        objEmpPrp = null;
        objEmp = null;
        GC.Collect();
    }
    protected void Gridview_Request_RowDeleting(object sender, GridViewDeleteEventArgs e)//REJECT REQUEST
    {
        objEmp = new clsEmp();
        objEmpPrp = new clsEmpPrp();
        objEmpPrp.Pemp_id = Convert.ToInt32(Gridview_Request.DataKeys[e.RowIndex][0]);
        objEmp.del_request(objEmpPrp);
        Free_Memory();
        gridview_request_bind();
    }
    protected void Gridview_Request_RowEditing(object sender, GridViewEditEventArgs e) //ACCEPT REQUEST
    {
        objEmp = new clsEmp();
        objEmpPrp = new clsEmpPrp();
        objEmpPrp.Pemp_id = Convert.ToInt32(Gridview_Request.DataKeys[e.NewEditIndex][0]);
        objEmp.accept_request(objEmpPrp);
        Free_Memory();
        gridview_request_bind();
    }
    

    //private void gridview_notification_bind()
    //{
    //    obj = new clsSoftware();
    //    Gridview_Notification.DataSource = obj.disp_notification();
    //    Gridview_Notification.DataBind();
    //    Free_Memory();
    //}
    protected void Gridview_Notification_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


   protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        FormsAuthentication.SignOut();
        Response.Redirect("signin.aspx");
    }
}
