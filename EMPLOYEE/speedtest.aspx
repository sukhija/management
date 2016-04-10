<%@ Page Title="" Language="C#" MasterPageFile="~/EMPLOYEE/MasterPage.master" AutoEventWireup="true" CodeFile="speedtest.aspx.cs" Inherits="EMPLOYEE_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinkButton ID="lbl_current_speed" CssClass="btn" runat="server" 
        onclick="lbl_current_speed_Click">Check Your Speed</asp:LinkButton><br />
    <asp:LinkButton ID="lbl_results" CssClass="btn" runat="server" 
        onclick="lbl_results_Click">Results</asp:LinkButton>


    <div id="div_check_your_speed" runat="server" visible="true">
   <asp:Button ID="btnStartTest" runat="server" Text="Start Test" onclick="btnStartTest_Click" 
     CssClass="form-control" data-toggle="modal" data-target="#Check_Speed_Modal"/>
       <div id="div_current_result" runat="server" visible="false"  
            style="margin-top:50px;" class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2" >
       <h1>YOUR CURRENT SPEED</h1>
       <table>
                    <tr><td>MAC ADDRESS:</td><td><asp:Label ForeColor="Green" ID="lblMacAddress" runat="server"></asp:Label><tr><td>
                    <tr><td>HOST NAME:</td><td><asp:Label ForeColor="Green" ID="lblHostName" runat="server"></asp:Label><tr><td>
                    <tr><td>LOCAL IP ADDRESS:</td><td><asp:Label ForeColor="Green" ID="lblIP" runat="server"></asp:Label><tr><td>
                    <tr><td>DOWNLOADING SPEED:</td><td><asp:Label ForeColor="Green" ID="lblDLSpeed" runat="server">KB</asp:Label><tr><td>
                    <tr><td>UPLOADIND SPEED:</td><td><asp:Label ForeColor="Green" ID="lblULSpeed" runat="server">KB</asp:Label><tr><td>
       </table>
             </div>
   </div>
    
    <center>
    <div id="div_results" runat="server" visible="false">
        <h1 align="center">INTERNET SPEED RESULTS</h1>
        <table class="table-responsive" >
      <tr style="max-width:1200px;">
        <td style="max-width:600px" align="left" valign="top">
        <div style="float:left; max-width:200px; padding:5px;">IP:
                <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList1" runat="server" AppendDataBoundItems="true"
                    DataSourceID="SqlDataSource1" DataTextField="mac_ip" DataValueField="mac_ip">
                    <asp:ListItem Selected="True" Text="Select IP Address"></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cn %>" 
                    SelectCommand="SELECT distinct [mac_ip] FROM [tb_net_speed]"></asp:SqlDataSource>
        </div>
        <div style="float:left; max-width:150px; padding:5px;">DATE:
                <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList2" runat="server" AppendDataBoundItems="true"
                    DataSourceID="SqlDataSource2" DataTextField="date" DataValueField="date">
                    <asp:ListItem Selected="True" Text="Select Date" Value="-1"></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cn %>" 
                    SelectCommand="select DISTINCT CONVERT(VARCHAR(11),date,106) AS date from tb_net_speed"></asp:SqlDataSource>
        </div>          
        <div style="float:left; max-width:150px; padding:5px;">TIME:
            <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList3" runat="server">
                <asp:ListItem Selected="True" Text="Select Time" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Early Morning" Value="0"></asp:ListItem>
                <asp:ListItem Text="Morning" Value="1"></asp:ListItem>
                <asp:ListItem Text="Noon" Value="2"></asp:ListItem>
                <asp:ListItem Text="Evening" Value="3"></asp:ListItem>
                <asp:ListItem Text="Night" Value="4"></asp:ListItem>
                <asp:ListItem Text="Late Night" Value="5"></asp:ListItem>
             </asp:DropDownList>
        </div>
        <div style="float:left; max-width:150px; padding:25px 5px;" >
                <asp:Button ID="BtnFilterResult" CssClass="form-control" runat="server" Text="Search" 
                    onclick="BtnFilterResult_Click" />
        </div>  <br />
        <div style="max-width:500px; padding-left:5px; max-height:500px; overflow-y:scroll;" align="center">  
        <br />
                <asp:GridView HorizontalAlign="Center" ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" BorderWidth="2px">
                    <Columns>
                        <asp:TemplateField HeaderText="DATE" SortExpression="date" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("date") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TIME" SortExpression="time" Visible="false" ControlStyle-Width="55px" ItemStyle-HorizontalAlign="Right">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("time") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="DOWNLOAD SPEED (KB)" SortExpression="net_dl_speed" ItemStyle-HorizontalAlign="Right">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("net_dl_speed") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="UPLOAD SPEED (KB)" SortExpression="net_ul_speed"  ItemStyle-HorizontalAlign="Right">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("net_ul_speed") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </div>        
      </td>  
      
        <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
        <ContentTemplate>
             <td style="max-width:900px; border-left: 1px solid#888; " valign="top">
        <div style="float:left; max-width:200px; padding:5px;">IP:
                <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList4" runat="server" AppendDataBoundItems="true"
                    DataSourceID="SqlDataSource1" DataTextField="mac_ip" DataValueField="mac_ip">
                    <asp:ListItem Selected="True" Text="Select IP Address"></asp:ListItem>
                </asp:DropDownList>
                
        </div>
        <div style="float:left; max-width:200px; padding:5px;">DATE FROM:
                <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList5" runat="server" AppendDataBoundItems="true"
                    DataSourceID="SqlDataSource2" DataTextField="date" DataValueField="date">
                    <asp:ListItem Selected="True" Text="Select Date" Value="-1"></asp:ListItem>
                </asp:DropDownList>
        </div>
        <div style="float:left; max-width:200px; padding:5px;">DATE TO:
                <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList6" runat="server" AppendDataBoundItems="true"
                    DataSourceID="SqlDataSource2" DataTextField="date" DataValueField="date">
                    <asp:ListItem Selected="True" Text="Select Date" Value="-1"></asp:ListItem>
                </asp:DropDownList>
        </div>          
        <div style="float:left; max-width:200px; padding:5px;">WEEK DAY:
            <asp:DropDownList CssClass="form-control scrollable-menu" ID="DropDownList7" runat="server">
                <asp:ListItem Selected="True" Text="Select Week Day" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Sunday" Value="Sunday"></asp:ListItem>
                <asp:ListItem Text="Monday" Value="Monday"></asp:ListItem>
                <asp:ListItem Text="Tuesday" Value="Tuesday"></asp:ListItem>
                <asp:ListItem Text="Wednesday" Value="Wednesday"></asp:ListItem>
                <asp:ListItem Text="Thusday" Value="Thusday"></asp:ListItem>
                <asp:ListItem Text="Friday" Value="Friday"></asp:ListItem>
                <asp:ListItem Text="Saturday" Value="Saturday"></asp:ListItem>
             </asp:DropDownList>
        </div>
        <div style="float:right; max-width:150px; padding:25px 5px;" >
                <asp:Button ID="Button2" CssClass="form-control" runat="server" Text="Search" onclick="Button2_Click" />
        </div>  
        <div style="max-width:500px; padding:5px; max-height:600px;"> 
             <asp:Chart ID="Chart1" runat="server" Height="500px" Width="700px" >
            <Series>
                <asp:Series XValueType="String" YValueType="String" YValueMembers="download_speed" XValueMember="time" Name="Series1" ChartArea="ChartArea1">
                </asp:Series>
                <asp:Series XValueType="String" YValueType="String" YValueMembers="upload_speed" XValueMember="time" Name="Series2" ChartArea="ChartArea1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                <AxisX Title="TIME"></AxisX>
                <AxisY Title="SPEED"></AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
             <br />
        </div>
             </td>
        </ContentTemplate>
        </asp:UpdatePanel>
    </tr> 
    </table>
    </div>
    </center>
</asp:Content>

