<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="notifications.aspx.cs" Inherits="ADMIN_Default" %>
<%@ MasterType VirtualPath="~/ADMIN/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <center>  <div style="width:1300px;">
    
    
    <h1><b>NOTIFICATIONS</b></h1>
    <h2><ul>HARDWARE</ul></h2>
    <asp:GridView ID="GridView_hardware_notification" Width="100%" runat="server" AutoGenerateColumns="False" DataKeyNames="hardware_id" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="hardware_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="hardware_id" />
            <asp:BoundField DataField="hardware_name" HeaderText="NAME" ReadOnly="True" SortExpression="Column1" />
            <asp:BoundField DataField="hardware_manufacturer" HeaderText="MANUFACTURER" SortExpression="hardware_manufacturer" />
            <asp:BoundField DataFormatString="{0:D}" DataField="hardware_purchase_date" HeaderText="PURCHHASE DATE" SortExpression="hardware_purchase_date" />
            <asp:BoundField DataField="hardware_purchase_file_number" HeaderText="PURCHASE FILE NO" SortExpression="hardware_purchase_file_number" />
            <asp:BoundField DataFormatString="{0:D}" DataField="hardware_warrenty" HeaderText="WARRENTY" SortExpression="hardware_warrenty" />
            <asp:BoundField DataFormatString="{0:D}" DataField="hardware_annual_maintenance_contract" HeaderText="AMC" SortExpression="hardware_annual_maintenance_contract" />
            <asp:BoundField DataField="hardware_annual_maintenance_contract_detail" HeaderText="AMC DETAIL" SortExpression="hardware_annual_maintenance_contract_detail" />
            <asp:BoundField DataField="hardware_annual_maintenance_contract_number" HeaderText="AMC CONTACTS" SortExpression="hardware_annual_maintenance_contract_number" />
            <asp:BoundField DataField="hardware_serial_no_or_service_tag_number" HeaderText="SERIAL NO" SortExpression="hardware_serial_no_or_service_tag_number" />
            <asp:BoundField DataField="name" HeaderText="EMPLOYEE NAME" ReadOnly="True" SortExpression="name" />
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cn %>" SelectCommand="notification_hardware" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <h2><ul>SOFTWARE</ul></h2>
    <asp:GridView ID="GridView_software_notification" runat="server" AutoGenerateColumns="False" DataKeyNames="software_id" DataSourceID="SqlDataSource2" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="software_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="software_id" />
            <asp:BoundField DataField="software_name" HeaderText="NAME" ReadOnly="True" SortExpression="Column1" />
            <asp:BoundField DataField="software_manufacturer" HeaderText="MANUFACTURER" SortExpression="software_manufacturer" />
            <asp:BoundField DataField="software_purchase_date" HeaderText="PURCHHASE DATE" SortExpression="software_purchase_date" DataFormatString="{0:D}" />
            <asp:BoundField DataField="software_purchase_file_number" HeaderText="PURCHASE FILE NO" SortExpression="software_purchase_file_number" />
            <asp:BoundField DataField="software_warrenty" HeaderText="WARRENTY" SortExpression="software_warrenty"  DataFormatString="{0:D}"/>
            <asp:BoundField DataField="software_annual_maintenance_contract" HeaderText="AMC" SortExpression="software_annual_maintenance_contract" DataFormatString="{0:D}" />
            <asp:BoundField DataField="software_annual_maintenance_contract_detail" HeaderText="AMC DETAIL" SortExpression="software_annual_maintenance_contract_detail" />
            <asp:BoundField DataField="software_annual_maintenance_contract_number" HeaderText="AMC CONTACTS" SortExpression="software_annual_maintenance_contract_number" />
            <asp:BoundField DataField="software_serial_number_or_service_tag_number" HeaderText="SERIAL NO" SortExpression="software_serial_number_or_service_tag_number" />
            <asp:BoundField DataField="name" HeaderText="EMPLOYEE NAME" ReadOnly="True" SortExpression="name" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:cn %>" SelectCommand="notification_software" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <h2><ul>MISCELLANEOUS</ul></h2>
    <asp:GridView ID="GridView_miscellaneous_notification" runat="server" AutoGenerateColumns="False" DataKeyNames="miscellaneous_id" DataSourceID="SqlDataSource3" EnableModelValidation="True" Width="100%">
        <Columns>
            <asp:BoundField DataField="miscellaneous_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="miscellaneous_id" />
            <asp:BoundField DataField="miscellaneous_product_name" HeaderText="NAME" SortExpression="miscellaneous_product_name" />
            <asp:BoundField DataField="miscellaneous_manufacturer" HeaderText="MANUFACTURER" SortExpression="miscellaneous_manufacturer" />
            <asp:BoundField DataFormatString="{0:D}" DataField="miscellaneous_purchase_date" HeaderText="PURCHHASE DATE" SortExpression="miscellaneous_purchase_date" />
            <asp:BoundField DataField="miscellaneous_purchase_file_number" HeaderText="PURCHASE FILE NO" SortExpression="miscellaneous_purchase_file_number" />
            <asp:BoundField DataFormatString="{0:D}" DataField="miscellaneous_warrenty" HeaderText="WARRENTY" SortExpression="miscellaneous_warrenty" />
            <asp:BoundField DataFormatString="{0:D}" DataField="miscellaneous_annual_maintenance_contract" HeaderText="AMC" SortExpression="miscellaneous_annual_maintenance_contract" />
            <asp:BoundField DataField="miscellaneous_annual_maintenance_contract_detail" HeaderText="AMC DETAIL" SortExpression="miscellaneous_annual_maintenance_contract_detail" />
            <asp:BoundField DataField="miscellaneous_annual_maintenance_contract_number" HeaderText="AMC CONTACTS" SortExpression="miscellaneous_annual_maintenance_contract_number" />
            <asp:BoundField DataField="miscellaneous_serial_no_or_service_tag_number" HeaderText="SERIAL NO" SortExpression="miscellaneous_serial_no_or_service_tag_number" />
            <asp:BoundField DataField="name" HeaderText="EMPLOYEE NAME" ReadOnly="True" SortExpression="name" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:cn %>" SelectCommand="notification_miscellaneous" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <br />
    
    </div></center>
    <center>
    
  </center>
</asp:Content>

