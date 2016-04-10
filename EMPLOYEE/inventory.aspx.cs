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
using System.Windows.Forms;
using System.Drawing;
using nsAdmin;

public partial class EMPLOYEE_Default : System.Web.UI.Page
{
    
    //clsHardwarePrp objHardwarePrp;
    clsHardware objHardware;
    //clsSoftwarePrp objSoftwarePrp;
    clsSoftware objSoftware;
    //clsStationaryPrp objStationaryPrp;
    clsStationary objStationary;
    //clsMiscellaneousPrp objMislaneousPrp;
    clsMiscellaneous objMislaneous;
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.P_Text = "My Inventory Room";
        if (!IsPostBack)
        {
            common_grid_bind();
        }
    }
    private void common_grid_bind()
    {
        objHardware = new clsHardware();
        GridView_hardware.DataSource = objHardware.disp_emp_HW_rec(Convert.ToString(Session["id"]));
        GridView_hardware.DataBind();
        
        objSoftware = new clsSoftware();
        GridView_software.DataSource = objSoftware.disp_emp_SW_rec(Convert.ToString(Session["id"]));
        GridView_software.DataBind();
        
        objMislaneous = new clsMiscellaneous();
        GridView_miscellaneous.DataSource = objMislaneous.disp_emp_MIS_rec(Convert.ToString(Session["id"]));
        GridView_miscellaneous.DataBind();
        
        objStationary = new clsStationary();
        GridView_stationary.DataSource = objStationary.disp_emp_Stationary_rec(Convert.ToString(Session["id"]));
        GridView_stationary.DataBind();

    }

    protected void GridView_software_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DateTime Warrenty_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Psoftware_warrenty_from"));
            DateTime Purchase_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Psoftware_purchase_date"));
            DateTime AMC_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Psoftware_annual_maintenance_contract_from"));
            if (Warrenty_Start_Date == DateTime.Today || Purchase_Date == DateTime.Today || AMC_Start_Date == DateTime.Today)
            {
                e.Row.BackColor = Color.Green;
                e.Row.ForeColor = Color.White;
                
            }


//---------------------------------------------EXPIRY WARRENTY/AMC LOGIC-----------------------------------------            
            DateTime Warrenty_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Psoftware_warrenty_to"));
            DateTime AMC_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Psoftware_annual_maintenance_contract_to"));
            TimeSpan Warrenty_Critical_Time = Warrenty_Expiry_Date - DateTime.Today;
            TimeSpan AMC_Critical_Time = AMC_Expiry_Date - DateTime.Today;
            if (Warrenty_Critical_Time.Days <= 30 && AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Red;
                e.Row.ForeColor = Color.White;

            }
            else if (Warrenty_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Orange;
                e.Row.ForeColor = Color.Black;

            }
            else if (AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Orange;
                e.Row.ForeColor = Color.Black;

            }

        }
        else if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
        }
            
    }
    protected void GridView_hardware_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DateTime Warrenty_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_warrenty_from"));
            DateTime Purchase_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_purchase_date"));
            DateTime AMC_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_annual_maintenance_contract_from"));
            if (Warrenty_Start_Date == DateTime.Today || Purchase_Date == DateTime.Today || AMC_Start_Date == DateTime.Today)
            {
                e.Row.BackColor = Color.Green;
                e.Row.ForeColor = Color.White;
            }

            DateTime Warrenty_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_warrenty_to"));
            DateTime AMC_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_annual_maintenance_contract_to"));

            TimeSpan Warrenty_Critical_Time = Warrenty_Expiry_Date - DateTime.Today;
            TimeSpan AMC_Critical_Time = AMC_Expiry_Date - DateTime.Today;
            if (Warrenty_Critical_Time.Days <= 30 && AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Red;
                e.Row.ForeColor = Color.White;
                
            }
            else if (Warrenty_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Orange;
                e.Row.ForeColor = Color.Black;
               
            }
            else if (AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Orange;
                e.Row.ForeColor = Color.Black;
               
            }

        }
        else if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
        }
    }
    protected void GridView_stationary_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
        }
    }
    protected void GridView_miscellaneous_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DateTime Warrenty_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_warrenty_from"));
            DateTime Purchase_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_purchase_date"));
            DateTime AMC_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_annual_maintenance_contract_from"));
            if (Warrenty_Start_Date == DateTime.Today || Purchase_Date == DateTime.Today || AMC_Start_Date == DateTime.Today)
            {
                e.Row.BackColor = Color.Green;
                e.Row.ForeColor = Color.White;
            }

            DateTime Warrenty_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_warrenty_to"));
            DateTime AMC_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_annual_maintenance_contract_to"));

            TimeSpan Warrenty_Critical_Time = Warrenty_Expiry_Date - DateTime.Today;
            TimeSpan AMC_Critical_Time = AMC_Expiry_Date - DateTime.Today;
            if (Warrenty_Critical_Time.Days <= 30 && AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Red;
                e.Row.ForeColor = Color.White;

            }
            else if (Warrenty_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Orange;
                e.Row.ForeColor = Color.Black;

            }
            else if (AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Orange;
                e.Row.ForeColor = Color.Black;

            }

        }
        else if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
        }
    }
}
