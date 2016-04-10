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
using nsAdmin;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

public partial class ADMIN_Default4 : System.Web.UI.Page
{
    clsHardwarePrp objPrp;
    clsHardware obj;

    protected void Page_Load(object sender, EventArgs e)
    {
        Master.P_Text = "Hardware";
        if (!Page.IsPostBack)
        {
            grid_bind();
            //Btn_Cancel.Visible = false;
        }
        string screen_width = Convert.ToString(Screen.PrimaryScreen.WorkingArea.Width - 100);
        string screen_height = Convert.ToString(Screen.PrimaryScreen.WorkingArea.Height - 100);
        ScriptManager.RegisterStartupScript(Page, this.GetType(), "Key", "<script>MakeStaticHeader('" + GridView1.ClientID + "', '" + screen_height + "', '" + screen_width + "' , 60); </script>", false);
    }

    protected void Btn_Submit_Click(object sender, EventArgs e)         // SUBMIT AND UPDATE
    {
        if (Page.IsValid)
        {
            obj = new clsHardware();
            objPrp = new clsHardwarePrp();
            objPrp.Phardware_name = DropDownList5.SelectedValue.ToString();
            objPrp.Phardware_manufacturer = TextBox2.Text;
            objPrp.Phardware_model = TextBox3.Text;
            objPrp.Phardware_purchase_date = Convert.ToDateTime(TextBox4.Text);
            objPrp.Phardware_purchase_file_number = TextBox5.Text;
            if (TextBox6.Text != "" && TextBox7.Text != "")  // warrenty
            {
                objPrp.Phardware_warrenty_from = Convert.ToDateTime(TextBox6.Text);
                objPrp.Phardware_warrenty_to = Convert.ToDateTime(TextBox7.Text);
            }
            if (TextBox8.Text != "" && TextBox9.Text != "") // AMC
            {
                objPrp.Phardware_annual_maintenance_contract_from = Convert.ToDateTime(TextBox8.Text);
                objPrp.Phardware_annual_maintenance_contract_to = Convert.ToDateTime(TextBox9.Text);
            }
            objPrp.Phardware_annual_maintenance_contract_detail = TextArea1.Value;
            objPrp.Phardware_annual_maintenance_contract_number = TextBox10.Text;
            objPrp.Phardware_serial_no_or_service_tag_number = TextBox11.Text;
            objPrp.Phardware_mac_address = TextBox12.Text;
            objPrp.Phardware_type = TextBox13.Text;
            objPrp.Phardware_usb_support = Convert.ToBoolean(DropDownList1.SelectedValue == "Yes" ? true : false);
            objPrp.Phardware_resolution = TextBox14.Text;
            objPrp.Phardware_night_vision = Convert.ToBoolean(DropDownList2.SelectedValue == "Yes" ? true : false); //Convert.ToBoolean(DropDownList2.SelectedIndex);
            objPrp.Phardware_processor = TextBox15.Text;
            objPrp.Phardware_graphics_card = TextBox16.Text;
            objPrp.Phardware_dvd_writer = TextBox17.Text;
            objPrp.Phardware_operating_system = TextBox18.Text;
            objPrp.Phardware_keyboard = TextBox19.Text;
            objPrp.Phardware_mouse = TextBox20.Text;
            objPrp.Phardware_hard_disc_size = TextBox21.Text;
            objPrp.Phardware_ram_size = TextBox22.Text;
            objPrp.Phardware_monitor = TextBox23.Text;
            objPrp.Phardware_system_architecture = TextBox24.Text;
            objPrp.Phardware_os_architecture = TextBox25.Text;
            objPrp.Phardware_screen_guard = TextBox26.Text;
            objPrp.Phardware_laptop_charger = TextBox27.Text;
            objPrp.Phardware_ups_rating = TextBox28.Text;
            objPrp.Phardware_wire_length = TextBox29.Text;
            objPrp.Phardware_page_yield = TextBox30.Text;
            objPrp.Phardware_wireless = Convert.ToBoolean(DropDownList3.SelectedValue == "Yes" ? true : false);                             //---------------------------------------------------------
            objPrp.Phardware_supported_standards = TextBox31.Text;
            // objPrp.Phardware_emp_id
            if (CheckBox4.Checked == false)
            {
                objPrp.Phardware_emp_id = Convert.ToInt32(DropDownList4.SelectedValue);
            }


            // DropDownList1.
            if (Btn_Submit.Text == "Save")
            {
                obj.save_rec(objPrp);
                DropDownList5.Focus();
                //TextBox1.Focus();
            }
            else if (Btn_Submit.Text == "Update")
            {
                objPrp.Phardware_id = Convert.ToInt32(ViewState["Index_Of_Editing_Row"]);
                obj.upd_rec(objPrp);
                Btn_Submit.Text = "Save";
                Btn_Cancel.Text = "Reset";
                DropDownList5.Enabled = true;
            }
            clear_rec();
            grid_bind();
            Free_Memory();
        }
    }
    protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox4.Checked == true)
        {
            DropDownList4.Enabled = false;
        }
        else
            DropDownList4.Enabled = true;
    }


    private void clear_rec()
    {
        DropDownList5.SelectedIndex = -1;
        TextBox2.Text = string.Empty;
        TextBox3.Text = string.Empty;
        TextBox4.Text = string.Empty;
        TextBox5.Text = string.Empty;
        TextBox6.Text = string.Empty;
        TextBox7.Text = string.Empty;
        TextBox8.Text = string.Empty;
        TextBox9.Text = string.Empty;
        TextBox10.Text = string.Empty;
        TextBox11.Text = string.Empty;
        TextBox12.Text = string.Empty;
        TextBox13.Text = string.Empty;
        TextBox14.Text = string.Empty;
        TextBox15.Text = string.Empty;
        TextBox16.Text = string.Empty;
        TextBox17.Text = string.Empty;
        TextBox18.Text = string.Empty;
        TextBox19.Text = string.Empty;
        TextBox20.Text = string.Empty;
        TextBox21.Text = string.Empty;
        TextBox22.Text = string.Empty;
        TextBox23.Text = string.Empty;
        TextBox24.Text = string.Empty;
        TextBox25.Text = string.Empty;
        TextBox26.Text = string.Empty;
        TextBox27.Text = string.Empty;
        TextBox28.Text = string.Empty;
        TextBox29.Text = string.Empty;
        TextBox30.Text = string.Empty;
        TextBox31.Text = string.Empty;

        DropDownList1.SelectedIndex = -1;
        DropDownList2.SelectedIndex = -1;
        DropDownList3.SelectedIndex = -1;
        DropDownList4.SelectedIndex = -1;
        TextArea1.Value = "";
        CheckBox4.Checked = false;
        DropDownList4.Enabled = true;

    }
    private void Free_Memory()
    {
        objPrp = null;
        obj = null;
        GC.Collect();
    }
    private void grid_bind()
    {
        obj = new clsHardware();
        GridView1.DataSource = obj.disp_rec();
        GridView1.DataBind();
        Free_Memory();

    }



    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        obj = new clsHardware();
        objPrp = new clsHardwarePrp();
        ViewState["Index_Of_Editing_Row"] = objPrp.Phardware_id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        objPrp = obj.find_rec(objPrp);
        //if (div_hw_entry_form.Visible == false)
        //{
        //    div_hw_entry_form.Visible = true;
        //    GridView1_heading.Visible = false;
        //}
        DropDownList5.Enabled = false;
        DropDownList5.SelectedValue = objPrp.Phardware_name;
        DropDownList5_SelectedIndexChanged(objPrp.Phardware_name, e);
        TextBox2.Text = objPrp.Phardware_manufacturer;
        TextBox3.Text = objPrp.Phardware_model;
        if (objPrp.Phardware_purchase_date != null)
            TextBox4.Text = Convert.ToString(objPrp.Phardware_purchase_date).Substring(0, 10);
        TextBox5.Text = objPrp.Phardware_purchase_file_number;
        if (objPrp.Phardware_warrenty_from != null && objPrp.Phardware_warrenty_from != null)
        {
            TextBox6.Text = Convert.ToString(objPrp.Phardware_warrenty_from).Substring(0, 10);
            TextBox7.Text = Convert.ToString(objPrp.Phardware_warrenty_to).Substring(0, 10);
        }
        if (objPrp.Phardware_annual_maintenance_contract_from != null && objPrp.Phardware_annual_maintenance_contract_to != null)
        {
            TextBox8.Text = Convert.ToString(objPrp.Phardware_annual_maintenance_contract_from).Substring(0, 10);
            TextBox9.Text = Convert.ToString(objPrp.Phardware_annual_maintenance_contract_to).Substring(0, 10);
        }
        TextArea1.Value = objPrp.Phardware_annual_maintenance_contract_detail;
        TextBox10.Text = objPrp.Phardware_annual_maintenance_contract_number;
        TextBox11.Text = objPrp.Phardware_serial_no_or_service_tag_number;
        TextBox12.Text = objPrp.Phardware_mac_address;
        TextBox13.Text = objPrp.Phardware_type;
        DropDownList1.SelectedIndex = Convert.ToInt32(objPrp.Phardware_usb_support == true ? 1 : 2);
        TextBox14.Text = objPrp.Phardware_resolution;
        DropDownList2.SelectedIndex = Convert.ToInt32(objPrp.Phardware_night_vision == true ? 1 : 2);
        TextBox15.Text = objPrp.Phardware_processor;
        TextBox16.Text = objPrp.Phardware_graphics_card;
        TextBox17.Text = objPrp.Phardware_dvd_writer;
        TextBox18.Text = objPrp.Phardware_operating_system;
        TextBox19.Text = objPrp.Phardware_keyboard;
        TextBox20.Text = objPrp.Phardware_mouse;
        TextBox21.Text = objPrp.Phardware_hard_disc_size;
        TextBox22.Text = objPrp.Phardware_ram_size;
        TextBox23.Text = objPrp.Phardware_monitor;
        TextBox24.Text = objPrp.Phardware_system_architecture;
        TextBox25.Text = objPrp.Phardware_os_architecture;
        TextBox26.Text = objPrp.Phardware_screen_guard;
        TextBox27.Text = objPrp.Phardware_laptop_charger;
        TextBox28.Text = objPrp.Phardware_ups_rating;
        TextBox29.Text = objPrp.Phardware_wire_length;
        TextBox30.Text = objPrp.Phardware_page_yield;
        DropDownList3.SelectedIndex = Convert.ToInt32(objPrp.Phardware_wireless == true ? 1 : 2);
        TextBox31.Text = objPrp.Phardware_supported_standards;
        if (objPrp.Phardware_emp_id != 0)
        {
            DropDownList4.SelectedValue = objPrp.Phardware_emp_id.ToString();
            CheckBox4.Checked = false;
            DropDownList4.Enabled = true;
        }
        else
        {
            CheckBox4.Checked = true;
            DropDownList4.Enabled = false;
        }

        Btn_Submit.Text = "Update";
        //Btn_Cancel.Visible = true;
        Btn_Cancel.Text = "Cancel";

        Free_Memory();
    }
    protected void Btn_Cancel_Click(object sender, EventArgs e)
    {

        clear_rec();
        if (Btn_Cancel.Text == "Cancel")
        {
            Btn_Submit.Text = "Save";
            //Btn_Cancel.Visible = false;
            CheckBox4.Checked = false;
            DropDownList4.Enabled = true;
            DropDownList5.Enabled = true;
            Btn_Cancel.Text = "Reset";
        }


    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj = new clsHardware();
        objPrp = new clsHardwarePrp();
        objPrp.Phardware_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objPrp);
        Free_Memory();
        grid_bind();
    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lk = (LinkButton)(e.Row.Cells[39].Controls[0]);
            e.Row.Attributes["OnClick"] = ClientScript.GetPostBackClientHyperlink(lk, "");


            DateTime Warrenty_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_warrenty_from"));
            DateTime Purchase_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_purchase_date"));
            DateTime AMC_Start_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_annual_maintenance_contract_from"));
            if (Warrenty_Start_Date == DateTime.Today || Purchase_Date == DateTime.Today || AMC_Start_Date == DateTime.Today)
            {
                e.Row.BackColor = Color.Green;
                e.Row.ForeColor = Color.White;
                e.Row.Cells[0].BackColor = Color.White;
                e.Row.Cells[0].ForeColor = Color.Blue;
                e.Row.Cells[1].BackColor = Color.White;
                e.Row.Cells[1].ForeColor = Color.Blue;
            }

            DateTime Warrenty_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_warrenty_to"));
            DateTime AMC_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Phardware_annual_maintenance_contract_to"));

            TimeSpan Warrenty_Critical_Time = Warrenty_Expiry_Date - DateTime.Today;
            TimeSpan AMC_Critical_Time = AMC_Expiry_Date - DateTime.Today;
            if (Warrenty_Critical_Time.Days <= 30 || AMC_Critical_Time.Days <= 30)
            {
                e.Row.BackColor = Color.Red;
                e.Row.ForeColor = Color.White;
                e.Row.Cells[0].BackColor = Color.White;
                e.Row.Cells[0].ForeColor = Color.Blue;
                e.Row.Cells[1].BackColor = Color.White;
                e.Row.Cells[1].ForeColor = Color.Blue;
            }

        }
        else if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
        }
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlCommand cmd = new SqlCommand("disp_hardware_specification", con);
        //SqlCommand cmd1 = new SqlCommand("SELECT column_name FROM information_schema.columns where table_name='tb_hardware_specifications'", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@h_name", SqlDbType.VarChar, 200).Value = DropDownList5.SelectedValue;
        if (con.State == ConnectionState.Closed)
            con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        //int j = 3;
        if (dr.Read())
        {
            int a = 7;
            for (int i = 3; i <= 35; i++, a = a + 2)
            {
                if (dr[i].ToString() == "False")
                {
                    div_hw_entry_form.Controls[a].Visible = false;
                }
                else if (dr[i].ToString() == "True")
                {
                    div_hw_entry_form.Controls[a].Visible = true;
                }
            }

        }
        div36.Visible = true;

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selected_row_key = GridView1.SelectedDataKey.Value.ToString();
        Response.Redirect("~/ADMIN/inventory_history.aspx?id=" + selected_row_key);
    }

    public void lk_insert_hw_form_Click(object sender, EventArgs e)
    {
        if (div_hw_entry_form.Visible == false)
        {
            div_hw_entry_form.Visible = true;
            GridView1_heading.Visible = false;
        }
        else
        {
            div_hw_entry_form.Visible = false;
            GridView1_heading.Visible = true;
        }
    }
    public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
    {

    }

    protected void btn_export_excel_Click(object sender, EventArgs e)
    {
        GridView1.Columns[0].Visible = false;
        GridView1.Columns[1].Visible = false;
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment;filename=Hardware_Inventory_" + DateTime.Now.ToString() + ".xls");
        Response.ContentType = "application/excel";

        StringWriter string_writer = new StringWriter();
        HtmlTextWriter html_text_writer = new HtmlTextWriter(string_writer);

        GridView1.RenderControl(html_text_writer);
        Response.Write(string_writer.ToString());
        Response.End();
    }
    protected void btn_export_pdf_Click(object sender, EventArgs e)
    {
        GridView1.Columns[0].Visible = false;
        GridView1.Columns[1].Visible = false;
        Response.ClearContent();
        PdfPTable pdfTable = new PdfPTable(GridView1.HeaderRow.Cells.Count);
        foreach (TableCell tableHeaderCell in GridView1.HeaderRow.Cells)
        {
            PdfPCell pdfPCell = new PdfPCell(new Phrase(tableHeaderCell.Text));
            pdfTable.AddCell(pdfPCell);
        }
        foreach (GridViewRow gridViewRow in GridView1.Rows)
        {
            foreach (TableCell tableCell in gridViewRow.Cells)
            {
                PdfPCell pdfCell = new PdfPCell(new Phrase(tableCell.Text));
                pdfTable.AddCell(pdfCell);
            }
        }
        Document pdfDoc = new Document(PageSize.A1, 10f, 10f, 10f, 10f);
        pdfDoc.SetPageSize(PageSize.A1.Rotate());
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        pdfDoc.Add(pdfTable);
        pdfDoc.Close();

        Response.ContentType = "application/pdf";
        Response.AppendHeader("content-disposition", "attachment;filename=Hardware_Inventory_" + DateTime.Now.ToString() + ".pdf");
        Response.Write(pdfDoc);
        Response.Flush();
        Response.End();


    }

}

