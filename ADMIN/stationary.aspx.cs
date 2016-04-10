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
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

public partial class ADMIN_Default : System.Web.UI.Page
{
    clsStationary obj = new clsStationary();
    clsStationaryPrp objPrp = new clsStationaryPrp();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.P_Text = "Stationary";
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
        obj = new clsStationary();
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
        obj = new clsStationary();
        objPrp = new clsStationaryPrp();
        objPrp.Pstationary_name = TextBox1.Text;
        objPrp.Pstationary_manufacturer = TextBox2.Text;
        objPrp.Pstationary_purchase_date = Convert.ToDateTime(TextBox3.Text);
        objPrp.Pstationary_purchase_file_number = TextBox4.Text;
        if (TextBox5.Text != "")
        {
            objPrp.Pstationary_quantity = Convert.ToInt32(TextBox5.Text);
        }
        else
        {
            objPrp.Pstationary_quantity = null;
        }
        if (CheckBox1.Checked == false)
        {
            objPrp.Pstationary_emp_id = Convert.ToInt32(DropDownList1.SelectedValue);
        }


        if (Btn_Submit_Update.Text == "Save")
        {
            obj.save_rec(objPrp);
            TextBox1.Focus();
        }
        else if (Btn_Submit_Update.Text == "Update")
        {
            objPrp.Pstationary_id = Convert.ToInt32(ViewState["Index_Of_Editing_Row"]);
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
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        obj = new clsStationary();
        objPrp = new clsStationaryPrp();
        //e.Cancel = true;
        Label1.Visible = true;    //ID text
        Label2.Visible = true;     //ID value

        //ViewState["Index_Of_Editing_Row"] = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        ViewState["Index_Of_Editing_Row"] = objPrp.Pstationary_id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);

        objPrp = obj.find_rec(objPrp);

        Label1.Text = "ID";
        Label2.Text = Convert.ToString(objPrp.Pstationary_id);
        TextBox1.Text = objPrp.Pstationary_name;
        TextBox2.Text = objPrp.Pstationary_manufacturer;
        TextBox3.Text = Convert.ToString(objPrp.Pstationary_purchase_date).Substring(0, 10);
        TextBox4.Text = objPrp.Pstationary_purchase_file_number;
        TextBox5.Text = Convert.ToString(objPrp.Pstationary_quantity);
        if (objPrp.Pstationary_emp_id != 0)
        {
            DropDownList1.SelectedValue = objPrp.Pstationary_emp_id.ToString();
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
        obj = new clsStationary();
        objPrp = new clsStationaryPrp();
        objPrp.Pstationary_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objPrp);
        Free_Memory();
        grid_bind();
    }
    private void clear_rec()
    {
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        TextBox3.Text = string.Empty;
        TextBox4.Text = string.Empty;
        TextBox5.Text = string.Empty;
        
        CheckBox1.Checked = false;
        DropDownList1.Enabled = true;

        DropDownList1.SelectedIndex = -1;
        
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
         if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
        }
    }
    public void lk_insert_stn_form_Click(object sender, EventArgs e)
    {
        if (tbl_stn_entry_form.Visible == false)
        {
            tbl_stn_entry_form.Visible = true;
            GridView1_heading.Visible = false;
        }
        else
        {
            tbl_stn_entry_form.Visible = false;
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
        Response.AppendHeader("content-disposition", "attachment;filename=Stationary_Inventory_" + DateTime.Now.ToString() + ".xls");
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
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        pdfDoc.Add(pdfTable);
        pdfDoc.Close();

        Response.ContentType = "application/pdf";
        Response.AppendHeader("content-disposition", "attachment;filename=Stationary_Inventory_" + DateTime.Now.ToString() + ".pdf");
        Response.Write(pdfDoc);
        Response.Flush();
        Response.End();


    }
}
