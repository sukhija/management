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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;

public partial class ADMIN_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        disp_rec();
        //Label1.Text = GridView1.Rows[1].Cells[0].ToString();
        //Label2.Text = GridView1.Rows[1].Cells[1].ToString();
        //Label3.Text = GridView1.Rows[1].Cells[2].ToString();
        //Label4.Text = GridView1.Rows[1].Cells[3].ToString();
        //Label5.Text = GridView1.Rows[1].Cells[4].ToString();
    }
    private void disp_rec()
    {
        Label7.Text = Request.QueryString["id"];
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlCommand cmd = new SqlCommand("disp_hardware_warrenty_history", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@hw_id", SqlDbType.Int).Value = Request.QueryString["id"];
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        Label1.Text = dr[0].ToString();
        Label2.Text = dr[1].ToString(); 
        Label3.Text = dr[2].ToString(); 
        Label4.Text = dr[3].ToString(); 
        Label5.Text = dr[4].ToString();
        Label6.Text = dr[5].ToString();
        con.Close();
        con.Open();
        GridView1.DataSource = cmd.ExecuteReader();
        GridView1.DataBind();
        cmd.Dispose();
        con.Close();
    }
    public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
    {

    }
    protected void btn_export_excel_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        string hw_id = Request.QueryString["id"];
        Response.AppendHeader("content-disposition", "attachment;filename=Hardware_ID=" + hw_id +" "+ DateTime.Now.ToString()+ ".xls");
        Response.ContentType = "application/excel";

        StringWriter string_writer = new StringWriter();
        HtmlTextWriter html_text_writer = new HtmlTextWriter(string_writer);

        //GridView1.HeaderRow.Style.Add("background-color", "#FFFFFF");
        //foreach (TableCell tablecell in GridView1.HeaderRow.Cells)
        //{
        //    tablecell.Style["background-color"] = Color.Red.ToString();
        //}

        GridView1.RenderControl(html_text_writer);
        Response.Write(string_writer.ToString());
        Response.End();
    }
    protected void btn_export_pdf_Click(object sender, EventArgs e)
    {
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
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        pdfDoc.Add(pdfTable);
        pdfDoc.Close();
        string hw_id = Request.QueryString["id"];
        Response.AppendHeader("content-disposition", "attachment;filename=Hardware_ID=" + hw_id + " " + DateTime.Now.ToString() + ".pdf");
        Response.ContentType = "application/pdf";
        Response.Write(pdfDoc);
        Response.Flush();
        Response.End();


    }
}
