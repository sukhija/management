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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
public partial class ADMIN_Default3 : System.Web.UI.Page
{
    clsMiscellaneous obj;
    clsMiscellaneousPrp objPrp;
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.P_Text = "Miscellaneous";
        if (!IsPostBack)
        {
            grid_bind();
        }
        string screen_width = Convert.ToString(Screen.PrimaryScreen.WorkingArea.Width - 100);
        string screen_height = Convert.ToString(Screen.PrimaryScreen.WorkingArea.Height - 100);
        ScriptManager.RegisterStartupScript(Page, this.GetType(), "Key", "<script>MakeStaticHeader('" + GridView1.ClientID + "', '" + screen_height + "', '" + screen_width + "' , 60); </script>", false);
        
    }

    private void grid_bind()
    {
        obj = new clsMiscellaneous();
        GridView1.DataSource = obj.disp_rec();
        GridView1.DataBind();
        Free_Memory();
    }
   
    private void Free_Memory()
    {
        objPrp = null;
        obj = null;
        GC.Collect();
    }

  
    protected void Btn_Submit_Update_Click(object sender, EventArgs e)
    {
        obj = new clsMiscellaneous();
        objPrp = new clsMiscellaneousPrp();
        objPrp.Pmiscellaneous_product_name = TextBox1.Text;
        objPrp.Pmiscellaneous_manufacturer = TextBox2.Text;
        objPrp.Pmiscellaneous_purchase_date = Convert.ToDateTime(TextBox3.Text);
        objPrp.Pmiscellaneous_purchase_file_number = TextBox4.Text;
        if (TextBox5.Text != "" && TextBox6.Text != "")
        {
            objPrp.Pmiscellaneous_warrenty_from = Convert.ToDateTime(TextBox5.Text);
            objPrp.Pmiscellaneous_warrenty_to = Convert.ToDateTime(TextBox6.Text);
        }
        if (TextBox7.Text != "" && TextBox8.Text != "")
        {
            objPrp.Pmiscellaneous_annual_maintenance_contract_from = Convert.ToDateTime(TextBox7.Text);
            objPrp.Pmiscellaneous_annual_maintenance_contract_to = Convert.ToDateTime(TextBox8.Text);
        }
        objPrp.Pmiscellaneous_annual_maintenance_contract_detail = TextArea1.Value;
        objPrp.Pmiscellaneous_annual_maintenance_contract_number = TextBox9.Text;
        objPrp.Pmiscellaneous_serial_no_or_service_tag_number = TextBox10.Text;
        if (TextBox11.Text != "")
        {
            objPrp.Pmiscellaneous_quantity = Convert.ToInt32(TextBox11.Text);
        }
        else
        {
            objPrp.Pmiscellaneous_quantity = null;
        }
        if (CheckBox1.Checked == false)
        {
            objPrp.Pmiscellaneous_emp_id = Convert.ToInt32(DropDownList1.SelectedValue);
        }


        if (Btn_Submit_Update.Text == "Save")
        {
            obj.save_rec(objPrp);
            TextBox1.Focus();
        }
        else if (Btn_Submit_Update.Text == "Update")
        {
            objPrp.Pmiscellaneous_id = Convert.ToInt32(ViewState["Index_Of_Editing_Row"]);
            obj.upd_rec(objPrp);
            Btn_Submit_Update.Text = "Save";
            Btn_Reset_Cancel.Text = "Reset";
            Label1.Visible = false;    //ID text
            Label2.Visible = false;     //ID value
        }
        clear_rec();
        grid_bind();
        Free_Memory();
    }
    protected void Btn_Reset_Cancel_Click(object sender, EventArgs e)
    {
        clear_rec();
        if (Btn_Reset_Cancel.Text == "Cancel")
        {
            Btn_Submit_Update.Text = "Save";
            //Btn_Cancel.Visible = false;
            Label1.Visible = false;    //ID text
            Label2.Visible = false;     //ID value
            Btn_Reset_Cancel.Text = "Reset";
        }
    }
    private void clear_rec()
    {
        TextBox1.Text = string.Empty;
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
        
        CheckBox1.Checked = false;
        DropDownList1.Enabled = true;
        
        DropDownList1.SelectedIndex = -1;
        TextArea1.Value = "";
        
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        obj = new clsMiscellaneous();
        objPrp = new clsMiscellaneousPrp();
        item_form.Visible = true;
        GridView1_heading.Visible = false;
        Label1.Visible = true;    //ID text
        Label2.Visible = true;     //ID value

        //ViewState["Index_Of_Editing_Row"] = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        ViewState["Index_Of_Editing_Row"] = objPrp.Pmiscellaneous_id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);

        objPrp = obj.find_rec(objPrp);

        Label1.Text = "ID";
        Label2.Text = Convert.ToString(objPrp.Pmiscellaneous_id);
        TextBox1.Text = objPrp.Pmiscellaneous_product_name;
        TextBox2.Text = objPrp.Pmiscellaneous_manufacturer;
        if(objPrp.Pmiscellaneous_purchase_date!=null)
            TextBox3.Text = Convert.ToString(objPrp.Pmiscellaneous_purchase_date).Substring(0, 10);
        TextBox4.Text = objPrp.Pmiscellaneous_purchase_file_number;
        if (objPrp.Pmiscellaneous_warrenty_from != null && objPrp.Pmiscellaneous_warrenty_from != null)
        {
            TextBox5.Text = Convert.ToString(objPrp.Pmiscellaneous_warrenty_from).Substring(0, 10);
            TextBox6.Text = Convert.ToString(objPrp.Pmiscellaneous_warrenty_to).Substring(0, 10);
        }
        if (objPrp.Pmiscellaneous_annual_maintenance_contract_from != null && objPrp.Pmiscellaneous_annual_maintenance_contract_to!= null)
        {
            TextBox7.Text = Convert.ToString(objPrp.Pmiscellaneous_annual_maintenance_contract_from).Substring(0, 10);
            TextBox8.Text = Convert.ToString(objPrp.Pmiscellaneous_annual_maintenance_contract_to).Substring(0, 10);
        }
        TextArea1.Value = objPrp.Pmiscellaneous_annual_maintenance_contract_detail;
        TextBox9.Text = objPrp.Pmiscellaneous_annual_maintenance_contract_number;
        TextBox10.Text = objPrp.Pmiscellaneous_serial_no_or_service_tag_number;
        TextBox11.Text = objPrp.Pmiscellaneous_quantity.ToString();
        if (objPrp.Pmiscellaneous_emp_id != 0)
        {
            DropDownList1.SelectedValue = objPrp.Pmiscellaneous_emp_id.ToString();
            CheckBox1.Checked = false;
            DropDownList1.Enabled = true;
        }
        else
        {
            CheckBox1.Checked = true;
            DropDownList1.Enabled = false;
        }

        Btn_Submit_Update.Text = "Update";
        //Btn_Cancel.Visible = true;
        Btn_Reset_Cancel.Text = "Cancel";

        Free_Memory();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj = new clsMiscellaneous();
        objPrp = new clsMiscellaneousPrp();
        objPrp.Pmiscellaneous_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objPrp);
        Free_Memory();
        grid_bind();
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            DropDownList1.Enabled = false;
        }
        else
            DropDownList1.Enabled = true;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Cells[0].BackColor = Color.White;
                e.Row.Cells[0].ForeColor = Color.Blue;
                e.Row.Cells[1].BackColor = Color.White;
                e.Row.Cells[1].ForeColor = Color.Blue;
            }

            DateTime Warrenty_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_warrenty_to"));
            DateTime AMC_Expiry_Date = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "Pmiscellaneous_annual_maintenance_contract_to"));

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
    public void lk_insert_item_form_Click(object sender, EventArgs e)
    {
        if (item_form.Visible == false)
        {
            item_form.Visible = true;
            GridView1_heading.Visible = false;
        }
        else
        {
            item_form.Visible = false;
            GridView1_heading.Visible = true;
        }
    }
    protected void btn_export_excel_Click(object sender, EventArgs e)
    {
        GridView1.Columns[0].Visible = false;
        GridView1.Columns[1].Visible = false;
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment;filename=Miscellaneous_Inventory_" + DateTime.Now.ToString() + ".xls");
        Response.ContentType = "application/excel";

        StringWriter string_writer = new StringWriter();
        HtmlTextWriter html_text_writer = new HtmlTextWriter(string_writer);

        GridView1.RenderControl(html_text_writer);
        Response.Write(string_writer.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
    {

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
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        pdfDoc.Add(pdfTable);
        pdfDoc.Close();

        Response.ContentType = "application/pdf";
        Response.AppendHeader("content-disposition", "attachment;filename=Miscellaneous_Inventory_" + DateTime.Now.ToString() + ".pdf");
        Response.Write(pdfDoc);
        Response.Flush();
        Response.End();


    }
}
