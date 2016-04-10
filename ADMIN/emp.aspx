<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="emp.aspx.cs" Inherits="ADMIN_Default" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/ADMIN/MasterPage.master" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
    <table ID="Table1" runat="server" width="100%">
    <tr>
        <td><center><h2>EMPLOYEES IN MIS</h2></center>
        </td>
    </tr>
    <tr>
        <td><center>
            <asp:UpdatePanel ID="UpdatePanel_for_GridView1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
<div style="width:1000px; overflow:scroll; height:450px;">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" onrowdeleting="GridView1_RowDeleting" DataKeyNames="Pemp_id" OnRowDataBound="GridView1_RowDataBound">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
    <EmptyDataTemplate>
        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
        AlternateText="No Data Available" runat="server" />
    </EmptyDataTemplate>
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:TemplateField HeaderText="BLOCK USER">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" Text="Block" CommandName="DELETE"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ID" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Pemp_id")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NAME">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Pemp_f_name")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="E-MAIL">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Pemp_email")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ADDRESS">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("Pemp_address")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CONTACT NO.">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("Pemp_c_number")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EXTENTION NO.">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("Pemp_e_number")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DATE OF BIRTH">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("Pemp_dob","{0:D}")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="GENDER">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("Pemp_gender")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="REGISTER DATE">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("Pemp_register_date","{0:D}")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Photo" >
                <ItemTemplate >
                    <asp:Image ID="img1" ImageUrl='<%#Eval("Pemp_picture_path",GetUrl("{0}")) %>' Width="120" Height="150"  runat="server"  />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle Height="120px" Width="120px" HorizontalAlign="Center" 
                    VerticalAlign="Middle" />
            </asp:TemplateField>
            
            
            
            
            
            
            
        </Columns>
    
        
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        
    
   
    </asp:GridView>
</div>
                    </ContentTemplate>
            </asp:UpdatePanel>
            </center></td>
        </tr>
    </table>
    </div>
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
