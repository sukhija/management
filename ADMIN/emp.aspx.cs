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
using nsUser;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

public partial class ADMIN_Default : System.Web.UI.Page
{
    clsEmpPrp objPrp;
    clsEmp obj;
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.P_Text = "Employee";
        if (!IsPostBack)
        {
            grid_bind(); 
        }
       
    }
    private void grid_bind()
    {
        obj = new clsEmp();
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
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj = new clsEmp();
        objPrp = new clsEmpPrp();
        objPrp.Pemp_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objPrp);
        Free_Memory();
        grid_bind();
    }
    protected string GetUrl(string imagepath)
    {
        string[] splits = Request.Url.AbsoluteUri.Split('/');
        if (splits.Length >= 2)
        {
            string url = splits[0] + "//";
            for (int i = 2; i < splits.Length - 1; i++)
            {
                url += splits[i];
                url += "/";
            }
            return url + imagepath;
        }
        return imagepath;
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.BackColor = Color.DarkOrchid;
            e.Row.ForeColor = Color.Yellow;
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
        Response.AppendHeader("content-disposition", "attachment;filename=Employees_" + DateTime.Now.ToString() + ".xls");
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
        Response.AppendHeader("content-disposition", "attachment;filename=Employees_" + DateTime.Now.ToString() + ".pdf");
        Response.Write(pdfDoc);
        Response.Flush();
        Response.End();


    }
}
