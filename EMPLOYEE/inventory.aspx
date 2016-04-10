<%@ Page Language="C#" MasterPageFile="~/EMPLOYEE/MasterPage.master" AutoEventWireup="true" CodeFile="inventory.aspx.cs" Inherits="EMPLOYEE_Default"
EnableEventValidation="true" MaintainScrollPositionOnPostback="true" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/EMPLOYEE/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
<div class="table-responsive"><table class="table">
 <tr align="center"><td><h2>HARDWARE ITEMS</h2></td></tr>
<tr align="center"><td>
   <asp:GridView Width="70%" ID="GridView_hardware" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    BackColor="White" EnableModelValidation="True" OnRowDataBound="GridView_hardware_RowDataBound">
                    <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                    <Columns>
                        
                        
                        <asp:TemplateField HeaderText="ID" SortExpression="Phardware_id">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Phardware_id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAME" SortExpression="Phardware_name">
                            
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Phardware_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MANUFACTURER" SortExpression="Phardware_manufacturer">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Bind("Phardware_manufacturer") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MODEL" 
                            SortExpression="Phardware_model">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Phardware_model") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PURCHASE DATE" 
                            SortExpression="Phardware_purchase_date">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" 
                                    Text='<%# Bind("Phardware_purchase_date","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PURCHASE FILE NO." 
                            SortExpression="Phardware_purchase_file_number">
                           <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" 
                                    Text='<%# Bind("Phardware_purchase_file_number") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WARRENTY FROM" 
                            SortExpression="Phardware_warrenty_from">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" 
                                    Text='<%# Bind("Phardware_warrenty_from","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WARRENTY TO" 
                            SortExpression="Phardware_warrenty_to">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" 
                                    Text='<%# Bind("Phardware_warrenty_to","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC FROM" 
                            SortExpression="Phardware_annual_maintenance_contract_from">
                             <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" 
                                    Text='<%# Bind("Phardware_annual_maintenance_contract_from","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC TO" 
                            SortExpression="Phardware_annual_maintenance_contract_to">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" 
                                    Text='<%# Bind("Phardware_annual_maintenance_contract_to","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC DETAIL" 
                            SortExpression="Phardware_annual_maintenance_contract_detail">
                           <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" 
                                    Text='<%# Bind("Phardware_annual_maintenance_contract_detail") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC NUMBER" 
                            SortExpression="Phardware_annual_maintenance_contract_number">
                            <ItemTemplate>
                                <asp:Label ID="Label12" runat="server" 
                                    Text='<%# Bind("Phardware_annual_maintenance_contract_number") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SERIAL NO./SERVICE TAG NO." 
                            SortExpression="Phardware_serial_no_or_service_tag_number">
                           <ItemTemplate>
                                <asp:Label ID="Label13" runat="server" 
                                    Text='<%# Bind("Phardware_serial_no_or_service_tag_number") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
       </asp:GridView>
</td></tr>
<tr align="center"><td><h2>SOFTWARE ITEMS</h2></td></tr>
<tr align="center"><td>
   <asp:GridView Width="70%" ID="GridView_software" runat="server" CellPadding="4" AutoGenerateColumns="False" BackColor="White" 
     BorderColor="#3366CC" onrowdatabound="GridView_software_RowDataBound">
                   
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <Columns>
                        <asp:TemplateField HeaderText="ID" sortExpression="Psoftware_id">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Psoftware_id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAME" SortExpression="Psoftware_name">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Psoftware_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MANUFACTURER" 
                            SortExpression="Psoftware_manufacturer">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("Psoftware_manufacturer") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="VERSION" SortExpression="Psoftware_version">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Psoftware_version") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PURCHASE DATE" 
                            SortExpression="Psoftware_purchase_date">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" 
                                    Text='<%# Eval("Psoftware_purchase_date","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="FILE NO." 
                            SortExpression="Psoftware_purchase_file_number">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" 
                                    Text='<%# Eval("Psoftware_purchase_file_number") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WARRENTY FROM" 
                            SortExpression="Psoftware_warrenty_from">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" 
                                    Text='<%# Eval("Psoftware_warrenty_from","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WARRENTY TO" 
                            SortExpression="Psoftware_warrenty_to">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" 
                                    Text='<%# Eval("Psoftware_warrenty_to","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC FROM" 
                            SortExpression="Psoftware_annual_maintenance_contract_from">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" 
                                    Text='<%# Eval("Psoftware_annual_maintenance_contract_from","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC TO" 
                            SortExpression="Psoftware_annual_maintenance_contract_to">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" 
                                    Text='<%# Eval("Psoftware_annual_maintenance_contract_to","{0:D}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC DETAIL" 
                            SortExpression="Psoftware_annual_maintenance_contract_detail">
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server"
                                    Text='<%# Eval("Psoftware_annual_maintenance_contract_detail") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AMC NO." 
                            SortExpression="Psoftware_annual_maintenance_contract_number">
                            <ItemTemplate>
                                <asp:Label ID="Label12" runat="server" 
                                    Text='<%# Eval("Psoftware_annual_maintenance_contract_number") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SERIAL NO./SERVICE TAG NO." 
                            SortExpression="Psoftware_serial_number_or_service_tag_number">
                            <ItemTemplate>
                                <asp:Label ID="Label13" runat="server" 
                                    Text='<%# Eval("Psoftware_serial_number_or_service_tag_number") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                    </Columns>
                    
                    <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                </asp:GridView>
</td></tr>   
<tr align="center"><td><h2>MISCELLANEOUS ITEMS</h2></td></tr>
<tr align="center"><td>
   <asp:GridView Width="70%" ID="GridView_miscellaneous" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" 
                BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowDataBound="GridView_miscellaneous_RowDataBound">
                <RowStyle BackColor="White" ForeColor="#003399" />
                <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Pmiscellaneous_id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NAME">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("Pmiscellaneous_product_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="MANUFACTURER">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%#Eval("Pmiscellaneous_manufacturer")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PURCHASE DATE">
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%#Eval("Pmiscellaneous_purchase_date","{0:D}")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FILE NO.">
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%#Eval("Pmiscellaneous_purchase_file_number")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="WARRENTY DATE FROM">
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%#Eval("Pmiscellaneous_warrenty_from","{0:D}")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="WARRENTY DATE TO">
                        <ItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%#Eval("Pmiscellaneous_warrenty_to","{0:D}")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="AMC DATE FROM">
                        <ItemTemplate>
                            <asp:Label ID="Label10" runat="server" Text='<%#Eval("Pmiscellaneous_annual_maintenance_contract_from","{0:D}")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="AMC DATE TO">
                        <ItemTemplate>
                            <asp:Label ID="Label11" runat="server" Text='<%#Eval("Pmiscellaneous_annual_maintenance_contract_to","{0:D}")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="AMC DETAIL">
                        <ItemTemplate>
                            <asp:Label ID="Label12" runat="server" Text='<%#Eval("Pmiscellaneous_annual_maintenance_contract_detail")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="AMC CONTACT NO.">
                        <ItemTemplate>
                            <asp:Label ID="Label13" runat="server" Text='<%#Eval("Pmiscellaneous_annual_maintenance_contract_number")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SERIAL NO./SERVICE TAG NO.">
                        <ItemTemplate>
                            <asp:Label ID="Label14" runat="server" Text='<%#Eval("Pmiscellaneous_serial_no_or_service_tag_number")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:Label ID="Label15" runat="server" Text='<%#Eval("Pmiscellaneous_quantity")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
</td></tr>
<tr align="center"><td><h2>STATIONARY ITEMS</h2></td></tr>
<tr align="center"><td>
   <asp:GridView Width="70%" ID="GridView_stationary" runat="server" AutoGenerateColumns="False" onrowdatabound="GridView_stationary_RowDataBound" >
                <RowStyle BackColor="White" ForeColor="#003399" />
                <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Pstationary_id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NAME">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("Pstationary_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="MANUFACTURER">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%#Eval("Pstationary_manufacturer")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PURCHASE DATE">
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%#Eval("Pstationary_purchase_date","{0:D}")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FILE NO.">
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%#Eval("Pstationary_purchase_file_number")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:Label ID="Label15" runat="server" Text='<%#Eval("Pstationary_quantity")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ASSIGNED TO EMPLOYEE">
                        <ItemTemplate>
                            <asp:Label ID="Label16" runat="server" Text='<%#Eval("Pstationary_emp_name")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
             </asp:GridView>
</td></tr>
</table></div></ContentTemplate></asp:UpdatePanel>
</asp:Content>

