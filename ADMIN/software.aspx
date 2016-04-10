<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="software.aspx.cs" Inherits="ADMIN_Default2" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/ADMIN/MasterPage.master" %>
<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <script language="javascript" type="text/javascript">
        function MakeStaticHeader(gridId, height, width, headerHeight) {
            var tbl = document.getElementById(gridId);
            if (tbl) {
                var DivHR = document.getElementById('DivHeaderRow');
                var DivMC = document.getElementById('DivMainContent');
                
                //*** Set divheaderRow Properties ****
                DivHR.style.height = headerHeight + 'px';
                DivHR.style.width = (parseInt(width)) + 'px';
                DivHR.style.position = 'relative';
                DivHR.style.top = '0px';
                DivHR.style.zIndex = '10';
                DivHR.style.verticalAlign = 'top';

                //*** Set divMainContent Properties ****
                DivMC.style.width = width + 'px';
                DivMC.style.maxHeight = height + 'px';
                DivMC.style.position = 'relative';
                DivMC.style.top = -headerHeight + 'px';
                DivMC.style.zIndex = '1';

                //*** Set divFooterRow Properties ****
               
                //****Copy Header in divHeaderRow****
                DivHR.appendChild(tbl.cloneNode(true));
            }
        }



        function OnScrollDiv(Scrollablediv) {
            document.getElementById('DivHeaderRow').scrollLeft = Scrollablediv.scrollLeft;
            document.getElementById('DivFooterRow').scrollLeft = Scrollablediv.scrollLeft;
        }


</script>
    
    <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <asp:LinkButton ID="lk_insert_sw_form" ToolTip="Insert new Software" runat="server"
               OnClick="lk_insert_sw_form_Click">Insert Software</asp:LinkButton>
        <div id="div_sw_entry_form" runat="server" class="table-responsive" visible="false">
            <table cellpadding="2" align="center" style="width:60%" class="table">
         <tr runat="server" >
            <td colspan="4">
                <center>
                <h2>ADD NEW SOFTWARE</h2></center>
            </td>
         </tr>
        <tr runat="server" >
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="false" ></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="false" ></asp:Label>
            </td>
            <td>
               
            </td>
            <td>

            </td>
        </tr>
        <tr runat="server" >
            <td>
                Name
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox1" runat="server" Height="25px"></asp:TextBox>
            </td>
            <td>
                 Warrenty Date To
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr runat="server" >
            <td>
                Manufacturer
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                AMC Date From
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr runat="server" >
            <td>
                Software Version
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                AMC Date To
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox9" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr runat="server" >
            <td>
                Purchase Date
            </td>
            <td>
                <asp:TextBox  class="form-control" ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                AMC Detail
            </td>
            <td>
                <textarea  class="form-control" id="TextArea1" rows="2" cols="20" runat="server"></textarea>
                
            </td>
        </tr>
        <tr runat="server" >
            <td>
                Purchase File No
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                AMC Contact No
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr runat="server" >
            <td>
                Warrenty Date From
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                Serial No or Service Tag No
            </td>
            <td>
                <asp:TextBox class="form-control"  ID="TextBox11" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr runat="server" >
            <td>
                <asp:Button class="form-control"  ID="Btn_Submit_Update" runat="server" onclick="Btn_Submit_Update_Click" Text="Save" BackColor="#9932cc" ForeColor="Yellow" />
            </td>
            <td>

                <asp:Button class="form-control"  ID="Btn_Reset_Cancel" runat="server" onclick="Btn_Reset_Cancel_Click" Text="Reset" BackColor="#9932cc" ForeColor="Yellow" />

            </td>
            <td>
                Assigned to Employee
            </td>
            <td>
            <asp:DropDownList class="form-control"  ID="DropDownList1" runat="server" 
                DataSourceID="ObjectDataSource1" DataTextField="Pemp_f_name"
                DataValueField="Pemp_id" AppendDataBoundItems="true">
                <asp:ListItem Text="Select" Selected="True"></asp:ListItem>
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                SelectMethod="disp_first_and_last_name" TypeName="nsUser.clsEmp"></asp:ObjectDataSource>
        </td>
        </tr>
        </table>
        </div>
        <center><h2 id="GridView1_heading" runat="server">SOFTWARE</h2>
        <div id="DivRoot" align="center">
                <div style="overflow: hidden;" id="DivHeaderRow">
                </div>

                <div style="overflow:scroll;" onscroll="OnScrollDiv(this)" id="DivMainContent">

                  <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
                    DataKeyNames="Psoftware_id" 
                    onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" 
                    BorderStyle="None" BorderWidth="1px" 
                    onrowdatabound="GridView1_RowDataBound">
                   
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <Columns>
                        <asp:CommandField ShowEditButton="True" HeaderText="EDIT"/>
                        <asp:TemplateField HeaderText="DELETE">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" CommandName="delete" Text="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
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
                        <asp:TemplateField HeaderText="ASSIGNED TO EMPLOYEE" 
                            SortExpression="Psoftware_emp_name">
                            <ItemTemplate>
                                <asp:Label ID="Label14" runat="server" Text='<%# Eval("Psoftware_emp_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    
                    <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                </asp:GridView>
                </div>
        </div>
           
   </ContentTemplate>
    </asp:UpdatePanel>
       <center>
    <table width="400px">
        <tr>
            <td><asp:Button ID="btn_export_excel" runat="server" Text="Export to Excel" Width="150px"
                CssClass="form-control" BackColor="#9932cc" ForeColor="Yellow" 
                    onclick="btn_export_excel_Click"/>
            </td>
            <td><asp:Button ID="btn_export_pdf" runat="server" Text="Export to PDF" Width="150px"
                CssClass="form-control" BackColor="#9932cc" ForeColor="Yellow" 
                    onclick="btn_export_pdf_Click"/>
            </td>
        </tr>
    </table>
  </center>
</asp:Content>

