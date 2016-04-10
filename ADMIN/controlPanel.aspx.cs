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

public partial class ADMIN_Default : System.Web.UI.Page
{
     SqlConnection con = new SqlConnection();
     
     
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlCommand cmd = new SqlCommand("ins_hardware_specifications", con);
        cmd.CommandType = CommandType.StoredProcedure;
        string item_name = TextBox1.Text.Substring(0, 1).ToUpper() + TextBox1.Text.Substring(1, TextBox1.Text.Length-1).ToLower();
        cmd.Parameters.Add("@hw_name", SqlDbType.VarChar, 200).Value = item_name.Trim();
        cmd.Parameters.Add("@hw_manufacturer", SqlDbType.Bit).Value = CheckBox2.Checked;
        cmd.Parameters.Add("@hw_model", SqlDbType.Bit).Value = CheckBox4.Checked;
        cmd.Parameters.Add("@hw_purchase_date", SqlDbType.Bit).Value = CheckBox6.Checked;
        cmd.Parameters.Add("@hw_purchase_file_number", SqlDbType.Bit).Value = CheckBox8.Checked;
        cmd.Parameters.Add("@hw_warrenty_from", SqlDbType.Bit).Value = CheckBox10.Checked;
        cmd.Parameters.Add("@hw_warrenty_to", SqlDbType.Bit).Value = CheckBox12.Checked;
        cmd.Parameters.Add("@hw_annual_maintenance_contract_from", SqlDbType.Bit).Value = CheckBox14.Checked;
        cmd.Parameters.Add("@hw_annual_maintenance_contract_to", SqlDbType.Bit).Value = CheckBox16.Checked;
        cmd.Parameters.Add("@hw_annual_maintenance_contract_detail", SqlDbType.Bit).Value = CheckBox18.Checked;
        cmd.Parameters.Add("@hw_annual_maintenance_contract_number", SqlDbType.Bit).Value = CheckBox20.Checked;
        cmd.Parameters.Add("@hw_serial_no_or_service_tag_number", SqlDbType.Bit).Value = CheckBox22.Checked;
        cmd.Parameters.Add("@hw_mac_address", SqlDbType.Bit).Value = CheckBox24.Checked;
        cmd.Parameters.Add("@hw_type", SqlDbType.Bit).Value = CheckBox26.Checked;
        cmd.Parameters.Add("@hw_usb_support", SqlDbType.Bit).Value = CheckBox28.Checked;
        cmd.Parameters.Add("@hw_resolution", SqlDbType.Bit).Value = CheckBox30.Checked;
        cmd.Parameters.Add("@hw_night_vision", SqlDbType.Bit).Value = CheckBox32.Checked;
        cmd.Parameters.Add("@hw_processor", SqlDbType.Bit).Value = CheckBox34.Checked;
        cmd.Parameters.Add("@hw_graphics_card", SqlDbType.Bit).Value = CheckBox1.Checked;
        cmd.Parameters.Add("@hw_dvd_writer", SqlDbType.Bit).Value = CheckBox3.Checked;
        cmd.Parameters.Add("@hw_operating_system", SqlDbType.Bit).Value = CheckBox5.Checked;
        cmd.Parameters.Add("@hw_keyboard", SqlDbType.Bit).Value = CheckBox7.Checked;
        cmd.Parameters.Add("@hw_mouse", SqlDbType.Bit).Value = CheckBox9.Checked;
        cmd.Parameters.Add("@hw_hard_disc_size", SqlDbType.Bit).Value = CheckBox11.Checked;
        cmd.Parameters.Add("@hw_ram_size", SqlDbType.Bit).Value = CheckBox13.Checked;
        cmd.Parameters.Add("@hw_monitor", SqlDbType.Bit).Value = CheckBox15.Checked;
        cmd.Parameters.Add("@hw_system_architecture", SqlDbType.Bit).Value = CheckBox17.Checked;
        cmd.Parameters.Add("@hw_os_architecture", SqlDbType.Bit).Value = CheckBox19.Checked;
        cmd.Parameters.Add("@hw_screen_guard", SqlDbType.Bit).Value = CheckBox21.Checked;
        cmd.Parameters.Add("@hw_laptop_charger", SqlDbType.Bit).Value = CheckBox23.Checked;
        cmd.Parameters.Add("@hw_ups_rating", SqlDbType.Bit).Value = CheckBox25.Checked;
        cmd.Parameters.Add("@hw_wire_length", SqlDbType.Bit).Value = CheckBox27.Checked;
        cmd.Parameters.Add("@hw_page_yield", SqlDbType.Bit).Value = CheckBox29.Checked;
        cmd.Parameters.Add("@hw_wireless", SqlDbType.Bit).Value = CheckBox31.Checked;
        cmd.Parameters.Add("@hw_supported_standards", SqlDbType.Bit).Value = CheckBox33.Checked;
        if (con.State == ConnectionState.Closed)
            con.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close(); 
        GridView1.DataBind();
        clear_rec();
    }//--------------INSERT SPECIFICATIONS OF H/W
    protected void Btn_Cancel_Click(object sender, EventArgs e)///----------------RESET ALL CHECKBOXES
    {
        clear_rec();
        CheckBox4.Checked = false;
        CheckBox10.Checked = false;
        CheckBox12.Checked = false;
        CheckBox14.Checked = false;
        CheckBox16.Checked = false;
        CheckBox18.Checked = false;
        CheckBox20.Checked = false;
        CheckBox22.Checked = false;

    }

    private void clear_rec()//------------------RESET METHOD
    {
        TextBox1.Text = string.Empty;
        CheckBox1.Checked = false;
        CheckBox3.Checked = false;
        CheckBox5.Checked = false;
        CheckBox7.Checked = false;
        CheckBox9.Checked = false;
        CheckBox11.Checked = false;
        CheckBox13.Checked = false;
        CheckBox15.Checked = false;
        CheckBox17.Checked = false;
        CheckBox19.Checked = false;
        CheckBox21.Checked = false;
        CheckBox23.Checked = false;
        CheckBox24.Checked = false;
        CheckBox25.Checked = false;
        CheckBox26.Checked = false;
        CheckBox27.Checked = false;
        CheckBox28.Checked = false;
        CheckBox29.Checked = false;
        CheckBox30.Checked = false;
        CheckBox31.Checked = false;
        CheckBox32.Checked = false;
        CheckBox33.Checked = false;
        CheckBox34.Checked = false;
    }
    
    protected void LinkButton1_Click(object sender, EventArgs e)//---------------EXPAND H/W SPECIFICATIONS ENTRY FORM
    {
        Panel_hw_specification_form.Visible = true;
    }
   
}
