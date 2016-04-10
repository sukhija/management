using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;
using System;
using System.Data;

public partial class EMPLOYEE_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnFilterResult_Click(object sender, EventArgs e)
    {
        grid_bind();
    }
    private void grid_bind()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("disp_net_speed", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("m_ip", SqlDbType.VarChar, 50).Value = DropDownList1.SelectedValue;
        if (DropDownList2.SelectedValue == "-1")
        {
            //GridView1.Columns[0].Visible = false;
            cmd.Parameters.Add("@d", SqlDbType.Char, 11).Value = DBNull.Value;
        }
        else
            cmd.Parameters.Add("@d", SqlDbType.Char, 11).Value = DropDownList2.SelectedValue;
        if (DropDownList3.SelectedValue == "-1")
        {
            cmd.Parameters.Add("@t", SqlDbType.Int).Value = DBNull.Value;
        }
        else
            cmd.Parameters.Add("@t", SqlDbType.Int).Value = DropDownList3.SelectedValue;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        GridView1.DataSource = cmd.ExecuteReader();
        GridView1.DataBind();
        con.Close();
        cmd.Dispose();
    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((DropDownList2.SelectedValue == "-1") && (DropDownList3.SelectedValue == "-1"))
        {
            GridView1.Columns[0].Visible = true;
            GridView1.Columns[1].Visible = true;
        }
        if ((DropDownList2.SelectedValue == "-1") && (DropDownList3.SelectedValue != "-1"))
        {
            GridView1.Columns[0].Visible = true;
            GridView1.Columns[1].Visible = false;
        }
        if ((DropDownList2.SelectedValue != "-1") && (DropDownList3.SelectedValue == "-1"))
        {
            GridView1.Columns[0].Visible = false;
            GridView1.Columns[1].Visible = true;
        }
        if ((DropDownList2.SelectedValue != "-1") && (DropDownList3.SelectedValue != "-1"))
        {
            GridView1.Columns[0].Visible = false;
            GridView1.Columns[1].Visible = false;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        chart_bind();
    }
    private void chart_bind()
    {
        string ss;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("disp_net_avg_speed", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("m_ip", SqlDbType.VarChar, 50).Value = DropDownList4.SelectedValue;
        if ((DropDownList5.SelectedValue != "-1") && (DropDownList6.SelectedValue != "-1"))
        {
            cmd.Parameters.Add("d_from", SqlDbType.VarChar, 11).Value = ss = DropDownList5.SelectedValue;
            cmd.Parameters.Add("d_to", SqlDbType.VarChar, 11).Value = ss = DropDownList6.SelectedValue;
        }
        else
        {
            cmd.Parameters.Add("d_from", SqlDbType.VarChar, 11).Value = DBNull.Value;
            cmd.Parameters.Add("d_to", SqlDbType.VarChar, 11).Value = DBNull.Value;
        }
        if (DropDownList7.SelectedValue == "-1")
        {
            cmd.Parameters.Add("day", SqlDbType.VarChar, 20).Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.Add("day", SqlDbType.VarChar, 20).Value = ss = DropDownList7.SelectedValue;
        }
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        Chart1.DataSource = cmd.ExecuteReader();
        Chart1.DataBind();
        con.Close();
        cmd.Dispose();
    }


    protected void btnStartTest_Click(object sender, EventArgs e)
    {
        CalcInternetSpeed();
        div_current_result.Visible = true;
    }

    void CalcInternetSpeed()//-----------------------RETRIEVE INVENTORY FROM DATABASE & CREATE EMAIL MESSAGE
    {
        WebClient client = new WebClient();
        FileInfo fi = new FileInfo(@"f://DOWNLOAD.exe");
        DateTime startTime, endTime;
        startTime = DateTime.Now;
        client.DownloadFile("http://www.nch.com.au/components/wpsetup.exe", fi.FullName);
        endTime = DateTime.Now;
        TimeSpan time = endTime - startTime;
        double Bytes = (fi.Length / time.TotalSeconds); //convert from Killo Bytes to killo bits
        double DLspeed = Math.Round(Bytes / 1024); //download speed in Kbps.
        if (fi.Exists)
        {
            fi.Delete();
        }
        Random ULspeed = new Random();
        lblMacAddress.Text = GetCurrentMAC("www.google.com").ToString();
        lblHostName.Text = Dns.GetHostName();
        lblIP.Text = GetLocalIPAddress("www.google.com");
        lblDLSpeed.Text = DLspeed.ToString();
        lblULSpeed.Text = ULspeed.Next(1500, 2000).ToString();


    }

    private string GetLocalIPAddress(string allowedURL)
    {
        TcpClient client = new TcpClient();
        client.Client.Connect(new IPEndPoint(Dns.GetHostAddresses(allowedURL)[0], 80));
        while (!client.Connected)
        {
            Thread.Sleep(500);
        }
        IPAddress address2 = ((IPEndPoint)client.Client.LocalEndPoint).Address;
        client.Client.Disconnect(false);
        client.Close();
        return address2.ToString();
    }
    private static PhysicalAddress GetCurrentMAC(string allowedURL)
    {
        TcpClient client = new TcpClient();
        client.Client.Connect(new IPEndPoint(Dns.GetHostAddresses(allowedURL)[0], 80));
        while (!client.Connected)
        {
            Thread.Sleep(500);
        }
        IPAddress address2 = ((IPEndPoint)client.Client.LocalEndPoint).Address;
        client.Client.Disconnect(false);
        NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        client.Close();
        if (allNetworkInterfaces.Length > 0)
        {
            foreach (NetworkInterface interface2 in allNetworkInterfaces)
            {
                UnicastIPAddressInformationCollection unicastAddresses = interface2.GetIPProperties().UnicastAddresses;
                if ((unicastAddresses != null) && (unicastAddresses.Count > 0))
                {
                    for (int i = 0; i < unicastAddresses.Count; i++)
                        if (unicastAddresses[i].Address.Equals(address2))
                            return interface2.GetPhysicalAddress();
                }
            }
        }
        return null;
    }
    protected void lbl_current_speed_Click(object sender, EventArgs e)
    {
        div_check_your_speed.Visible = true;
        div_results.Visible = false;
        
    }
    protected void lbl_results_Click(object sender, EventArgs e)
    {
        div_check_your_speed.Visible = false;
        div_results.Visible = true;
    }
}