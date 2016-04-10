<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="inventory_history.aspx.cs" Inherits="ADMIN_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"  align="center">
    <h1>WARRENTY/AMC HISTORY</h1>
     <asp:Table ID="Table1" runat="server" Width="352px" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
               Product ID: 
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
               Product Name: 
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Manufacturar:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Model:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                purchase date:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Purchase file number:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
               Assigned to: 
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        EnableModelValidation="True" GridLines="Vertical" Width="650px" 
       >
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:TemplateField HeaderText="Warrenty" SortExpression="warrenty">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("warrenty") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="AMC" SortExpression="amc">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("amc") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UPDATE DATE" SortExpression="update_date">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("update_date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="Yellow" Font-Bold="True" ForeColor="Black" />
    
    </asp:GridView>
    <br />
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
    
</div>
</asp:Content>

