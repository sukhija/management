using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;
using System.Xml;
using System.Text;
using System.Xml.XPath;
using nsPing_utility;
using System.Web.UI.DataVisualization.Charting;

public partial class EMPLOYEE_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void Pinging_Set(string ip_address)
    {
        Ping sender = new Ping();
        PingOptions options = new PingOptions();
        options.Ttl = 128;
        options.DontFragment = true;
        string data = "12345678901234567890123456789012";       //32 bytes of data.
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        int TimeOut = 120;                                      //In milliseconds.
        PingReply Reply = sender.Send(ip_address, TimeOut, buffer, options);
        XmlElement ParrentElement;
        XmlElement IP;
        XmlElement RTT;
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("~/PingUtility.xml"));
        if (Reply.Status == IPStatus.Success)
        {
            ParrentElement = doc.CreateElement("ping_" + Reply.Address.ToString());
            IP = doc.CreateElement("IP");    //IP Address
            ViewState["ip_address"] = IP.InnerText = Reply.Address.ToString();
            RTT = doc.CreateElement("RTT"); //Round trip time
            RTT.InnerText = Reply.RoundtripTime.ToString();
            XmlElement DATE = doc.CreateElement("DATE");
            DATE.InnerText = DateTime.Now.ToString();            ////--------------------------------------------
            ParrentElement.AppendChild(IP);
            ParrentElement.AppendChild(RTT);
            ParrentElement.AppendChild(DATE);
            doc.DocumentElement.AppendChild(ParrentElement);

        }
        else if (Reply.Status == IPStatus.TimedOut)
        {
            ParrentElement = doc.CreateElement("ping_" + TextBox1.Text);
            IP = doc.CreateElement("IP");    //IP Address
            ViewState["ip_address"] = IP.InnerText = ParrentElement.LocalName.Substring(5, ParrentElement.LocalName.Length - 5);
            RTT = doc.CreateElement("RTT"); //Round trip time
            RTT.InnerText = "-5";                      //Request Time Out
            XmlElement DATE = doc.CreateElement("DATE");
            DATE.InnerText = DateTime.Now.ToString();            ////--------------------------------------------
            ParrentElement.AppendChild(IP);
            ParrentElement.AppendChild(RTT);
            ParrentElement.AppendChild(DATE);
            doc.DocumentElement.AppendChild(ParrentElement);

        }
        doc.Save(Server.MapPath("~/PingUtility.xml"));
    }

    private void Pinging_Get()
    {
        XPathDocument doc = new XPathDocument(Server.MapPath("~/PingUtility.xml"));
        XPathNavigator nav = doc.CreateNavigator();
        //DateTime new_date = DateTime.Now.AddSeconds(-10);
        string st = "_" + ViewState["ip_address"];
        XPathNodeIterator itr_IP;
        XPathNodeIterator itr_RTT;
        XPathNodeIterator itr_Date;
        itr_IP = nav.Select("pings/ping" + st + "/IP");
        itr_RTT = nav.Select("pings/ping" + st + "/RTT");
        itr_Date = nav.Select("pings/ping" + st + "/DATE");
        List<clsPingingPrp> obj = new List<clsPingingPrp>();
        string now_date = DateTime.Now.ToString();
        itr_IP.MoveNext();
        if (itr_IP.Current.Value == ViewState["ip_address"].ToString())
        {
            while ((itr_IP.Current.Value == ViewState["ip_address"].ToString()) && (itr_Date.MoveNext()) && (itr_RTT.MoveNext()))
            {
                if ((itr_Date.Current.Value.Substring(0, 9)) == now_date.Substring(0, 9))
                {
                    if ((Convert.ToInt32(itr_Date.Current.Value.Substring(17, 1))) >=
                        (Convert.ToInt32(Convert.ToString(DateTime.Now.AddSeconds(-10)).Substring(17, 1))))
                    {
                        if (((itr_Date.Current.Value.Substring(14, 1)) == now_date.Substring(14, 1)) ||
                            ((Convert.ToInt32(itr_Date.Current.Value.Substring(14, 1))) ==
                             (Convert.ToInt32(Convert.ToString(DateTime.Now.AddMinutes(-1)).Substring(14, 1)))))
                        {
                            if (((itr_Date.Current.Value.Substring(11, 1)) == now_date.Substring(11, 1)) ||
                                ((Convert.ToInt32(itr_Date.Current.Value.Substring(11, 1))) ==
                                 (Convert.ToInt32(Convert.ToString(DateTime.Now.AddHours(-1)).Substring(11, 1)))))
                            {
                                clsPingingPrp k = new clsPingingPrp();
                                k.P_IP = itr_IP.Current.Value;
                                if (itr_RTT.Current.ValueAsInt >= 0)
                                {
                                    k.P_RTT = itr_RTT.Current.Value;
                                    k.P_DATE = itr_Date.Current.Value;

                                }
                                //else
                                //{
                                //    k.P_RTT = "-5";
                                //    k.P_DATE = itr_Date.Current.Value;
                                //}
                                obj.Add(k);
                            }
                        }
                    }
                }
            }
        }
        chart1.Series[0].XValueMember = "P_DATE";
        chart1.Series[0].YValueMembers = "P_RTT";
        chart1.DataSource = obj;
        chart1.DataBind();
        //chart1.ChartAreas[0].AxisY.

    }
    protected void btn_Stop_Pinging_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = false;
        Pinging_Get();
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {

        Pinging_Set(TextBox1.Text);
        Pinging_Get();
        Timer1.Enabled = true;

    }
}