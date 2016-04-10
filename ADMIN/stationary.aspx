<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="stationary.aspx.cs" Inherits="ADMIN_Default" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/ADMIN/MasterPage.master"%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
 <script language="javascript" type="text/javascript">
        function MakeStaticHeader(gridId, height, width, headerHeight) {
            var tbl = document.getElementById(gridId);
            if (tbl) {
                var DivHR = document.getElementById('DivHeaderRow');
                var DivMC = document.getElementById('DivMainContent');
                
                //*** Set divheaderRow Properties ****
                DivHR.style.maxHeight = headerHeight + 'px';
                DivHR.style.maxWidth = (parseInt(width)) + 'px';
                DivHR.style.position = 'relative';
                DivHR.style.top = '0px';
                //DivHR.style.zIndex = '10';
                DivHR.style.verticalAlign = 'top';

                //*** Set divMainContent Properties ****
                DivMC.style.maxWidth = width + 'px';
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
        <asp:LinkButton ID="lk_insert_stn_form" ToolTip="Insert new Stationary" runat="server"
               OnClick="lk_insert_stn_form_Click">Insert Stationary</asp:LinkButton>
            <table id="tbl_stn_entry_form" runat="server" style="width: 40%" cellpadding="2" align="center" class="table table-responsive" visible="false">
    <tr>
        <td colspan="4"><center><h2>ADD NEW STATIONARY ITEM</h2></center>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
        Product Name
        </td>
        <td>
            <asp:TextBox class="form-control"  ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        
    </tr>
    <tr>
        <td>
        Manufacturer
        </td>
        <td>
        <asp:TextBox class="form-control"  ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        </tr>
    <tr>
        <td>
        Purchase Date
        </td>
        <td>
        <asp:TextBox class="form-control"  ID="TextBox3" runat="server"></asp:TextBox>
        </td>
       
    </tr>
    <tr>
        <td>
        Purchase File No.
        </td>
        <td>
        <asp:TextBox class="form-control"  ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        
    </tr>
    <tr>
        
        <td>
            Quantity
        </td>
        <td>
        <asp:TextBox class="form-control"  ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        
        <td>
            Reserved For Future OR Non Assignable
        </td>
        <td>
            <asp:CheckBox class="checkbox checkbox-inline" ID="CheckBox1" runat="server" Text="Yes" AutoPostBack="true"
                oncheckedchanged="CheckBox1_CheckedChanged" />
        </td>
    </tr>
    <tr>
        
        <td>
            Assigned to Employee</td>
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
    <tr>
        <td>
        
            <asp:Button  class="form-control" ID="Btn_Submit_Update" runat="server" Text="Save" onclick="Btn_Submit_Update_Click" BackColor="#9932cc" ForeColor="Yellow" />
            </td>
          <td>  <asp:Button  class="form-control" ID="Btn_Reset_Cancel" runat="server" onclick="Btn_Reset_Cancel_Click" Text="Reset" BackColor="#9932cc" ForeColor="Yellow" />
        
        
        
        
        </td>
        
    </tr>
    </table>
    <center><h2 id="GridView1_heading" runat="server">Stationary</h2>
<div id="DivRoot" align="center">
    <div style="overflow: hidden;" id="DivHeaderRow">
    </div>

    <div style="overflow:scroll;" onscroll="OnScrollDiv(this)" id="DivMainContent">
            <asp:GridView ID="GridView1" runat="server" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" 
                BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                DataKeyNames="Pstationary_id" onrowdeleting="GridView1_RowDeleting" 
                onrowediting="GridView1_RowEditing" 
                onrowdatabound="GridView1_RowDataBound" >
                <RowStyle BackColor="White" ForeColor="#003399" />
                <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                <Columns>
                    <asp:CommandField HeaderText="EDIT" ShowEditButton="True" />
                    <asp:TemplateField HeaderText="DELETE">
                        <ItemTemplate>
                             <asp:Button ID="Button1" runat="server" Text="Delete" CommandName="DELETE" />
                        </ItemTemplate>
                    </asp:TemplateField>
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
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
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

