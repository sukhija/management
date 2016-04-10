<%@ Page Title="" Language="C#" MasterPageFile="~/EMPLOYEE/MasterPage.master" AutoEventWireup="true" CodeFile="pingtest.aspx.cs" Inherits="EMPLOYEE_Default" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %> 
   
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <style type="text/css">
        
        .ping_box
        {
        	/*background-color:black;*/
        	height:500px;
            max-height:1000px;
        	margin:5px;
            /*color:white;*/
            
            vertical-align:middle;
            
        }
    </style>
    <center>
    <div style="max-width:1000px;">
    <div>

    <h1>PING TEST</h1>
            
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" >
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000" Enabled="false" OnTick="Timer1_Tick"></asp:Timer>
                    <span style="float:left;"><b>ENTER VALID IP ADDRESS OR DOMAIN:</b></span>
                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" Text="127.0.0.1"></asp:TextBox>
                   <br /> <asp:Button ID="btn_Start_Pinging" runat="server" Text="Start Pinging" 
                        OnClick="Timer1_Tick"  CssClass="form-control" />
                    <asp:Button ID="btn_Stop_Pinging" runat="server" Text="Stop Pinging"
                        OnClick="btn_Stop_Pinging_Click" CssClass="form-control"/>
                    <br />
                    
                    <span style="height:5px;"></span>
                    <asp:Chart runat="server" ID="chart1" Height="362px" Width="401px" 
                        Palette="Berry">
                        <series>
                            <asp:Series Name="Series1">
                            <Points>
                                
                            </Points>
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                                <AxisX ArrowStyle="SharpTriangle" Title="DATE"  ></AxisX>
                                <AxisY ArrowStyle="SharpTriangle" Title="RTT"></AxisY>
                            </asp:ChartArea>
                        </chartareas>
                    </asp:Chart>
                    
                    
                </ContentTemplate>
            </asp:UpdatePanel>
   
  
     </div>   
      </div>
      </center>  
        
  
    
</asp:Content>

