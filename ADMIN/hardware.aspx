<%@ Page Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/ADMIN/MasterPage.master" 
EnableEventValidation="false" AutoEventWireup="true" CodeFile="hardware.aspx.cs" Inherits="ADMIN_Default4" Title="Untitled Page" %>


<%@ MasterType VirtualPath="~/ADMIN/MasterPage.master" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="content1">
   
     
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

//        $(document).ready(function() {
//            $("#flip").click(function() {
//                $("#panel").slideToggle("slow");
//                document.getElementById('GridView1_heading').style.visibility = "hidden";
//            });
//        });

</script>
<script runat="server">

</script>
    <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
       <div style="max-width:1400px";>
               
 <!---------------------------START OF HARDWARE ITEM ENTRY FORM------------------------------------------>
<asp:LinkButton ID="lk_insert_hw_form" ToolTip="Insert new hardware" runat="server"
               OnClick="lk_insert_hw_form_Click" CausesValidation="False">Insert Hardware</asp:LinkButton>
     <%-- <div id="flip" class="btn">Insert Hardware</div>
           <asp:Panel ID="panel" Visible="false">

<div id="panel"  visible="false">--%>
<div id="div_hw_entry_form" runat="server" style="width:1300px; padding-left:100px;" visible="false">
<center>
                <h2>ADD NEW HARDWARE</h2>
      <div id="div0" runat="server" style="width:50%;">     
        </div>

      <div id="div1" runat="server" style="width:40%; float:left;">  

            <div  style="width:50%; float:left;" align="left">
            Hardware Name<br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
              ControlToValidate="DropDownList5" Display="Dynamic" SetFocusOnError="True" ErrorMessage="Name cannot be empty."
              InitialValue="Select" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <asp:DropDownList ID="DropDownList5"  runat="server" AutoPostBack="True" CssClass="form-control" Width="200px"
                    DataSourceID="SqlDataSource1" DataTextField="hardware_name" DataValueField="hardware_name" 
                    onselectedindexchanged="DropDownList5_SelectedIndexChanged" AppendDataBoundItems="true">
                    <asp:ListItem Text="Select" Selected="True"></asp:ListItem>
        </asp:DropDownList>
          
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cn %>" 
                    SelectCommand="SELECT [hardware_name] FROM [tb_hardware_specifications] ORDER BY [hardware_name]">
        </asp:SqlDataSource>
        <%-- <asp:TextBox ID="TextBox6" Width="200px" runat="server" CssClass="form-control" ></asp:TextBox>--%>
      </div>
            
      <div id="div2" runat="server" style="width:40%; float:left;" >  
      
       <div  style="width:50%; float:left;" align="left">
           
           Manufacturer<i style="color:Red;">*</i>
           <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
               ControlToValidate="TextBox2" Display="Dynamic" SetFocusOnError="True" 
               ErrorMessage="Manufacturer cannot be empty." Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator></div>
                <asp:TextBox ID="TextBox2" Width="200px" runat="server" CssClass="form-control" ></asp:TextBox>
      </div>
      
      <div  style="width:40%; float:left;" id="div3" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Model</div>
                <asp:TextBox ID="TextBox3" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div style="width:40%; float:left;" id="div4" visible="false" runat="server" >  
      <div  style="width:50%; float:left;" align="left">
      
          Purchase Date<i style="color:Red;">*</i>
          <br />
          <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
              ErrorMessage="Warrenty Date(From) must be in correct format (dd/mm/yyyy)" 
              Display="Dynamic" SetFocusOnError="True" 
              ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" 
              ControlToValidate="TextBox4" Font-Size="Smaller"  ForeColor="Red"></asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
              ControlToValidate="TextBox4" Display="Dynamic" SetFocusOnError="True" ErrorMessage="Purchase Date cannot be empty."></asp:RequiredFieldValidator>
              </div>
                <asp:TextBox ID="TextBox4" Width="200px"  runat="server"  placeholder="dd/mm/yyyy"
              CssClass="form-control"></asp:TextBox>
               
      </div>
      
      <div style="width:40%; float:left;" id="div5" visible="false" runat="server" >  
       <div  style="width:50%; float:left;" align="left">
           
           Purchase File No<i style="color:Red;">*</i>
           <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
               ControlToValidate="TextBox5" Display="Dynamic" SetFocusOnError="True" 
               ErrorMessage="Purchase file number cannot be empty." Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
               </div>
                <asp:TextBox ID="TextBox5" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div  style="width:40%; float:left;" id="div6" visible="true" runat="server">  
      <div  style="width:50%; float:left;" align="left">
               Warrenty Date From <br />
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
              ErrorMessage="Warrenty Date(From) must be in correct format (dd/mm/yyyy)" 
              Display="Dynamic" SetFocusOnError="True" 
              ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" 
              ControlToValidate="TextBox6" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
      </div>
                <asp:TextBox ID="TextBox6" Width="200px"  placeholder="dd/mm/yyyy"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div style="width:40%; float:left;" id="div7" visible="false" runat="server">  
       <div  style="width:50%; float:left;" align="left">
               Warrenty Date To<br />
               <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Warrenty Date(To) must be greater than Warrenty Date(From)"
                ControlToValidate="TextBox7" ControlToCompare="TextBox6" 
                 Operator="GreaterThan" Type="Date" Display="Dynamic" SetFocusOnError="True" 
                   Font-Size="Smaller" ForeColor="Red"></asp:CompareValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                 runat="server" 
                 ErrorMessage="Warrenty Date(To) must be in correct format (dd/mm/yyyy)" 
                 Display="Dynamic" SetFocusOnError="True" 
                 ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" 
                 ControlToValidate="TextBox7" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>

       </div>
                <asp:TextBox ID="TextBox7" Width="200px"  placeholder="dd/mm/yyyy"  runat="server" CssClass="form-control" ></asp:TextBox>
               
      </div>
      
      <div style="width:40%; float:left;" id="div8" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">
              AMC Date From<br />
              <asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
                 runat="server" 
                 ErrorMessage="AMC Date(From) must be in correct format (dd/mm/yyyy)" 
                 Display="Dynamic" SetFocusOnError="True"
                 ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" 
                 ControlToValidate="TextBox8" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>

      </div>
                <asp:TextBox ID="TextBox8" Width="200px"  placeholder="dd/mm/yyyy"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div  style="width:40%; float:left;" id="div9" visible="false" runat="server">  
           <div  style="width:50%; float:left;" align="left">
                 AMC Date To<br />
                 <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="AMC Date(To) must be greater than AMC Date(From)"
                ControlToValidate="TextBox9" ControlToCompare="TextBox8" 
                 Operator="GreaterThan" Type="Date" Display="Dynamic" SetFocusOnError="True" 
                     Font-Size="Smaller" ForeColor="Red"></asp:CompareValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
                 runat="server" 
                 ErrorMessage="AMC Date(To) must be in correct format (dd/mm/yyyy)" 
                 Display="Dynamic" SetFocusOnError="True" 
                 ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" 
                 ControlToValidate="TextBox9" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
           </div>
                <asp:TextBox ID="TextBox9" Width="200px"  placeholder="dd/mm/yyyy"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div  style="width:40%; float:left;" id="div10" visible="false" runat="server">  
       <div  style="width:50%; float:left;" align="left">AMC Detail</div>
                <textarea id="TextArea1" style="width:200px;" runat="server" name="TA" cols="20" rows="2" class="form-control"></textarea>
            
      </div>
      
      <div  style="width:40%; float:left;" id="div11" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">
      AMC Contact No<br />
      <asp:RegularExpressionValidator ID="RegularExpressionValidator7" 
                 runat="server" 
                 ErrorMessage="AMC contact number cannot be greater than 10 digit." 
                 Display="Dynamic" SetFocusOnError="True"
                 ValidationExpression="([0-9]{10})" 
                 ControlToValidate="TextBox10" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
      </div>
                <asp:TextBox ID="TextBox10" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
       
      <div style="width:40%; float:left;" id="div12" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Serial No or Service Tag No</div>
                <asp:TextBox ID="TextBox11" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
           
      </div>
      
      <div style="width:40%; float:left;" id="div13" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">
        MAC Address<br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" 
                 runat="server" 
                 ErrorMessage="MAC address cannot be greater than 12 hexadecimal digits." 
                 Display="Dynamic" SetFocusOnError="True"
                 ValidationExpression="([0-9A-Fa-f]{12})"
                 ControlToValidate="TextBox12" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
      </div>
                <asp:TextBox ID="TextBox12" Width="200px"  runat="server" 
              CssClass="form-control" ></asp:TextBox>
      </div>
      
      <div style="width:40%; float:left;" id="div14" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Type</div>
                <asp:TextBox ID="TextBox13" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div  style="width:40%; float:left;" id="div15" visible="false" runat="server">  
       <div  style="width:50%; float:left;" align="left">
       USB Support<br />
       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
               ControlToValidate="DropDownList1" InitialValue="-1" Display="Dynamic" 
               SetFocusOnError="True" ErrorMessage="USB support cannot be empty." 
               Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
       </div>
                <asp:DropDownList ID="DropDownList1"  Width="200px"  runat="server"  CssClass="form-control" >
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem Value="No">No</asp:ListItem>
                </asp:DropDownList>
      </div>
      
      <div style="width:40%; float:left;" id="div16" visible="false" runat="server">  
       <div  style="width:50%; float:left;" align="left">Resolution (in pixel)</div>
                <asp:TextBox ID="TextBox14" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
           
      
      
      <div style="width:40%; float:left;" id="div17" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">
            Night Vision<br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
               ControlToValidate="DropDownList2" InitialValue="-1" Display="Dynamic" 
                SetFocusOnError="True" ErrorMessage="Night Vision cannot be empty." 
                Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </div>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="200px"  CssClass="form-control" >
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem Value="No">No</asp:ListItem>
                </asp:DropDownList>
      </div>
      
      <div style="width:40%; float:left;" id="div18" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Processor</div>
                <asp:TextBox ID="TextBox15" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
           
      <div style="width:40%; float:left;" id="div19" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Graphics Card Detail</div>
                <asp:TextBox ID="TextBox16" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
            
      </div>
      
      <div style="width:40%; float:left;" id="div20" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">DVD Writer</div>
                <asp:TextBox  ID="TextBox17" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div style="width:40%; float:left;" id="div21" visible="false" runat="server">  
       <div  style="width:50%; float:left;" align="left">Operating System</div>
                <asp:TextBox ID="TextBox18" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div style="width:40%; float:left;" id="div22" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Keyboard </div>
                <asp:TextBox  ID="TextBox19" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
            
      </div>
      
      <div style="width:40%; float:left;" id="div23" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Mouse</div>
                <asp:TextBox ID="TextBox20" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
          
      </div>
      
      <div style="width:40%; float:left;" id="div24" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Hard Disc Size</div>
                <asp:TextBox ID="TextBox21" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div style="width:40%; float:left;" id="div25" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">RAM Size</div>
                <asp:TextBox  ID="TextBox22" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
      
      </div>
      
      <div style="width:40%; float:left;" id="div26" visible="false" runat="server">  
     <div  style="width:50%; float:left;" align="left"> Monitor</div>
                <asp:TextBox ID="TextBox23" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox>
                
      </div>
      
      <div style="width:40%; float:left;" id="div27" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">System Architecture</div>
                <asp:TextBox ID="TextBox24" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div28" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">OS Architecture</div>
                <asp:TextBox ID="TextBox25" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div29" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Screen Guard</div>
                <asp:TextBox ID="TextBox26" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div30" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Laptop Charger</div>
                <asp:TextBox ID="TextBox27" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      <div style="width:40%; float:left;" id="div31" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">UPS Rating</div>
                <asp:TextBox ID="TextBox28" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div32" visible="false" runat="server">  
       <div  style="width:50%; float:left;" align="left">Wire Length</div>
                <asp:TextBox ID="TextBox29" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div33" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Page Yield</div>
                <asp:TextBox ID="TextBox30" Width="200px"  runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div34" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">
      Wireless<br />
      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
               ControlToValidate="DropDownList3" InitialValue="-1" Display="Dynamic" SetFocusOnError="True" 
               ErrorMessage="Wireless cannot be empty." Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
       </div>
                <asp:DropDownList ID="DropDownList3" runat="server" Width="200px"  CssClass="form-control" >
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem   Value="No">No</asp:ListItem>
                </asp:DropDownList>
      </div>
      
      <div style="width:40%; float:left;" id="div35" visible="false" runat="server">  
      <div  style="width:50%; float:left;" align="left">Supported Standards</div>
                <asp:TextBox Width="200px"  ID="TextBox31" runat="server" CssClass="form-control" ></asp:TextBox></div>
      
      <div style="width:40%; float:left;" id="div36" visible="false" runat="server">  
     <div  style="width:50%; float:left;" align="left"> Reserved For Future OR
                <br />
                Non Assignable</div>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox4" runat="server" Text="Yes" AutoPostBack="true" 
                oncheckedchanged="CheckBox4_CheckedChanged" CssClass="checkbox" Checked="true"/>

      </div>
      <div style="width:40%; float:left;" id="div37" runat="server">  
      <div  style="width:50%; float:left;" align="left">Assigned to Employee</div>
            <asp:DropDownList class="form-control"  ID="DropDownList4" runat="server"  Width="200px" 
                DataSourceID="ObjectDataSource1" DataTextField="Pemp_f_name" CssClass="form-control" Enabled="false"
                DataValueField="Pemp_id" AppendDataBoundItems="true">
                <asp:ListItem Text="Select" Selected="True" Value="-1"></asp:ListItem>
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                SelectMethod="disp_first_and_last_name" TypeName="nsUser.clsEmp"></asp:ObjectDataSource></div>
     

       <div id="div38" style="width:40%; float:left; padding:30px;" runat="server">  
             <div  style="width:50%; float:left;" align="left">
      <asp:Button  Width="200px"  class="form-control" ID="Btn_Submit" runat="server"  Text="Save"  CssClass="form-control"
                    onclick="Btn_Submit_Click"  BackColor="#9932cc" ForeColor="Yellow"/>
             </div>
                      <asp:Button Width="200px"   class="form-control" ID="Btn_Cancel" runat="server" 
                onclick="Btn_Cancel_Click" Text="Reset" BackColor="#9932cc" 
                 ForeColor="Yellow" CausesValidation="False"/>
        </div>
        </center>
      </div>
<%--  </div>--%>
<%-- </asp:Panel> --%>     
 <!---------------------------END OF HARDWARE ITEM ENTRY FORM------------------------------------------>
        
       <center><h2 id="GridView1_heading" runat="server">HARDWARE</h2>
    <div id="DivRoot" align="center">
    <div style="overflow: hidden;" id="DivHeaderRow">
    </div>
            
    <div style="overflow:scroll;" onscroll="OnScrollDiv(this)" id="DivMainContent">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    onrowediting="GridView1_RowEditing" DataKeyNames="Phardware_id" onrowdeleting="GridView1_RowDeleting"
                     BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                     EnableModelValidation="True" OnRowDataBound="GridView1_RowDataBound" 
                     RowStyle-BorderStyle="Groove" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <EmptyDataTemplate>
                        <asp:Image ID="Image1" ImageUrl="~/Images/sorry_no_data_available.png" 
                        AlternateText="No Data Available" runat="server" />
                    </EmptyDataTemplate>
                    <Columns>
                        
                        
                        
                        <asp:CommandField HeaderText="Edit"  ShowEditButton="True" />
                        <asp:TemplateField HeaderText="DELETE">
                            <ItemTemplate>
                                <asp:Button ID="Button5" runat="server" CommandName="delete" Text="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
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
                        <asp:TemplateField HeaderText="MODEL" SortExpression="Phardware_model">
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
                        <asp:TemplateField HeaderText="MAC ADDRESS" 
                            SortExpression="Phardware_mac_address">
                           <ItemTemplate>
                                <asp:Label ID="Label14" runat="server" 
                                    Text='<%# Bind("Phardware_mac_address") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TYPE" SortExpression="Phardware_type">
                            <ItemTemplate>
                                <asp:Label ID="Label15" runat="server" Text='<%# Bind("Phardware_type") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="USB SUPPORT" 
                            SortExpression="Phardware_usb_support">
                             <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" 
                                    Checked='<%# Bind("Phardware_usb_support") %>' Enabled="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RESOLUTION" 
                            SortExpression="Phardware_resolution">
                            <ItemTemplate>
                                <asp:Label ID="Label16" runat="server" 
                                    Text='<%# Bind("Phardware_resolution") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NIGHT VISION" 
                            SortExpression="Phardware_night_vision">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" 
                                    Checked='<%# Bind("Phardware_night_vision") %>' Enabled="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PROCESSOR" 
                            SortExpression="Phardware_processor">
                            <ItemTemplate>
                                <asp:Label ID="Label17" runat="server" 
                                    Text='<%# Bind("Phardware_processor") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="GRAPHICS CARD" 
                            SortExpression="Phardware_graphics_card">
                             <ItemTemplate>
                                <asp:Label ID="Label18" runat="server" 
                                    Text='<%# Bind("Phardware_graphics_card") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DVD WRITER" 
                            SortExpression="Phardware_dvd_writer">
                            <ItemTemplate>
                                <asp:Label ID="Label19" runat="server" 
                                    Text='<%# Bind("Phardware_dvd_writer") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OS" 
                            SortExpression="Phardware_operating_system">
                            <ItemTemplate>
                                <asp:Label ID="Label20" runat="server" 
                                    Text='<%# Bind("Phardware_operating_system") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="KEYBOARD" 
                            SortExpression="Phardware_keyboard">
                            <ItemTemplate>
                                <asp:Label ID="Label21" runat="server" Text='<%# Bind("Phardware_keyboard") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MOUSE" 
                            SortExpression="Phardware_mouse">
                           <ItemTemplate>
                                <asp:Label ID="Label22" runat="server" Text='<%# Bind("Phardware_mouse") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="HARD DISC SIZE" 
                            SortExpression="Phardware_hard_disc_size">
                            <ItemTemplate>
                                <asp:Label ID="Label23" runat="server" 
                                    Text='<%# Bind("Phardware_hard_disc_size") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RAM SIZE" 
                            SortExpression="Phardware_ram_size">
                            <ItemTemplate>
                                <asp:Label ID="Label24" runat="server" Text='<%# Bind("Phardware_ram_size") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MONITOR" 
                            SortExpression="Phardware_monitor">
                            <ItemTemplate>
                                <asp:Label ID="Label25" runat="server" Text='<%# Bind("Phardware_monitor") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SYSTEM ARCHITECTURE" 
                            SortExpression="Phardware_system_architecture">
                            <ItemTemplate>
                                <asp:Label ID="Label26" runat="server" 
                                    Text='<%# Bind("Phardware_system_architecture") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OS ARCHITECTURE" 
                            SortExpression="Phardware_os_architecture">
                            <ItemTemplate>
                                <asp:Label ID="Label27" runat="server" 
                                    Text='<%# Bind("Phardware_os_architecture") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SCREEN GUARD" 
                            SortExpression="Phardware_screen_guard">
                            <ItemTemplate>
                                <asp:Label ID="Label28" runat="server" 
                                    Text='<%# Bind("Phardware_screen_guard") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LAPTOP CHARGER" 
                            SortExpression="Phardware_laptop_charger">
                            <ItemTemplate>
                                <asp:Label ID="Label29" runat="server" 
                                    Text='<%# Bind("Phardware_laptop_charger") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="UPS RATING" 
                            SortExpression="Phardware_ups_rating">
                            <ItemTemplate>
                                <asp:Label ID="Label30" runat="server" 
                                    Text='<%# Bind("Phardware_ups_rating") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WIRE LENGTH" 
                            SortExpression="Phardware_wire_length">
                            <ItemTemplate>
                                <asp:Label ID="Label31" runat="server" 
                                    Text='<%# Bind("Phardware_wire_length") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PAGE YIELD" 
                            SortExpression="Phardware_page_yield">
                            <ItemTemplate>
                                <asp:Label ID="Label32" runat="server" 
                                    Text='<%# Bind("Phardware_page_yield") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WIRELESS" 
                            SortExpression="Phardware_wireless">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox3" runat="server" 
                                    Checked='<%# Bind("Phardware_wireless") %>' Enabled="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SUPPORTED STANDARDS" 
                            SortExpression="Phardware_supported_standards">
                            <ItemTemplate>
                                <asp:Label ID="Label33" runat="server" 
                                    Text='<%# Bind("Phardware_supported_standards") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ASSIGNEG TO EMPLOYEE" SortExpression="Phardware_emp_id">
                           <ItemTemplate>
                                <asp:Label ID="Label34" runat="server" Text='<%# Eval("Phardware_emp_fname") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowSelectButton="True" Visible="False" />
                    </Columns>
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="DarkOrchid" Font-Bold="True" ForeColor="#CCFF99" />
                </asp:GridView>
                </div>

    
    </div>
           
              
    </center>
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <center>
    <table width="400px">
        <tr>
            <td><asp:Button ID="btn_export_excel" runat="server" Text="Export to Excel" Width="150px"
                CssClass="form-control" BackColor="#9932cc" ForeColor="Yellow" 
                    onclick="btn_export_excel_Click" CausesValidation="False"/>
            </td>
            <td><asp:Button ID="btn_export_pdf" runat="server" Text="Export to PDF" Width="150px"
                CssClass="form-control" BackColor="#9932cc" ForeColor="Yellow" 
                    onclick="btn_export_pdf_Click" CausesValidation="False"/>
            </td>
        </tr>
    </table>
  
  
              
                 
               
    </center>
</asp:Content>
