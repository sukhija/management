<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="EMPLOYEE_Default2" Title="Untitled Page" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<form runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<center>
<div style="max-width:1200px;">
    <marquee onmouseover="this.stop()" onmouseout="this.start()">
            <span style="color:Red; font-size:large;"> 
               This website is under construction. Please use this web application only for testing purpose.
            </span></marquee>
        <div id="div_slider" style="max-width:800px; max-height:350px;" class="carousel-caption">
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        
            <asp:Timer ID="Timer_Image_slider" runat="server" Interval="3000" 
                ontick="Timer_Image_slider_Tick">
            </asp:Timer>
            
            <asp:Image ID="Image1" runat="server" CssClass="carousel-inner"/>
            
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>

        <div align="center" id="footer" style="position:fixed; max-width:800px; bottom:0px; " class="carousel-caption">
        <a href="http://mail.csio.res.in/rcmail/" target='_blank'> <img src="Images/stories/fb/webmail.png" height='35px' width='80px' title="Webmail" /></a>&nbsp;&nbsp;
        <a href="http://csio.res.in:8080/icsio/auth/ipcheck.aspx/" target='_blank'> <img src='Images/stories/fb/icsio.png' height='30px' width='75px' title="Intranet" /></a>&nbsp;&nbsp;
        <a href='https://www.facebook.com/CSIR-Central-Scientific-Instruments-Organisation-Chandigarh-India-996385960395456/timeline/' target='_blank'><img src='Images/stories/fb/facebook.jpg' height='35px' width='35px' title="Facebook"/></a>&nbsp;&nbsp;
        <a href="http://www.csir.res.in/" target='_blank'> <img src='Images/stories/fb/csir.png' height='35px' width='75px' title="CSIR" /></a>&nbsp;&nbsp;
        <a href="http://onecsir.res.in/ERPLogin/Welcome.aspx" target='_blank'> <img src='Images/stories/fb/onecsirlogo.jpg' height='35px' width='80px' title="OneCSIR" ></a>&nbsp;&nbsp;
         <a href='http://csio.res.in/index.php?option=com_content&view=article&id=158&Itemid=129'> <img src='Images/stories/fb/rti.png' height='35px' width='75px' title="RTI" ></a>&nbsp;&nbsp;
        &nbsp; <a href='http://www.nvsp.in/' target='_blank'><img src='Images/stories/fb/nvsp.jpg' title="National Voters Service Portal"></a>&nbsp;&nbsp;
        <a href="http://india.gov.in/" target='_blank'> <img src='Images/stories/fb/goilink.gif' height='35px' width='80px' title="National Portal Of India" ></a>&nbsp;&nbsp;
        <a href="http://digitalindia.gov.in/" target='_blank'> <img src='Images/stories/fb/digitalindia.jpg' height='35px' width='80px' title="Digital India" ></a><br/><br/>
        <div><a href='http://csio.res.in/index.php?option=com_content&view=article&id=213&Itemid=259'><font color="#9932cc">Disclaimer</font></a>&nbsp;|&nbsp;Copyright &#169 Central Scientific Instruments Organisation, Sector 30, Chandigarh; Email: Webmaster@csio.res.in  </div>
		</div>
    
    
</div>
</center>

</form>
</asp:Content>

