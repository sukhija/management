<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="controlPanel.aspx.cs" Inherits="ADMIN_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <div  style="padding-bottom:20px">
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Tell me more about the hardware</asp:LinkButton>
        <center>
        <asp:Panel ID="Panel_hw_specification_form" runat="server" Visible="false">
       
           
            <table  cellpadding="2" align="center" class="table table-bordered" style="width:1000px;">
        <tr>
            <td colspan="6">
               <center>
                <h2>ADD NEW HARDWARE</h2></center></td>
        </tr>
        
        <tr>
            <td  >
                Name</td>
            <td  >
                <asp:TextBox  Width="200px"  class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
            </td>

		 <td>
                Graphics Card Detail</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox1" runat="server" Text="Yes"/>
            </td>
            <td  >
                MAC Address</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox24" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td>
                Manufacturer</td>
           <td>
                <asp:CheckBox Enabled="false" Checked="true" class="checkbox checkbox-inline"  ID="CheckBox2" runat="server" Text="Yes"/>
            </td>
<td  >
                DVD Writer</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox3" runat="server" Text="Yes"/>
            </td>
            <td  >
                UPS Rating</td>
           <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox25" runat="server" Text="Yes"/>
            </td>

        </tr>
        <tr>
            <td  >
                Model</td>
            <td>
                <asp:CheckBox Checked="true" class="checkbox checkbox-inline"  ID="CheckBox4" runat="server" Text="Yes"/>
            </td>
<td  >
                Operating System</td>
           <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox5" runat="server" Text="Yes"/>
            </td>
             <td  >
                Type</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox26" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td  >
                Purchase Date</td>
            <td>
                <asp:CheckBox Enabled="false" Checked="true" class="checkbox checkbox-inline"  ID="CheckBox6" runat="server" Text="Yes"/>
            </td>
 <td  >
                Keyboard </td>
           <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox7" runat="server" Text="Yes"/>
            </td>
             <td  >
                Wire Length</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox27" runat="server" Text="Yes"/>
            </td>

        </tr>
        <tr>
            <td  >
                Purchase File No</td>
            <td>
                <asp:CheckBox Checked="true" Enabled="false" class="checkbox checkbox-inline"  ID="CheckBox8" runat="server" Text="Yes"/>
            </td>
<td  >
                Mouse</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox9" runat="server" Text="Yes"/>
            </td>
            <td  >
                USB Support</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox28" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td  >
                Warrenty Date From</td>
            <td>
                <asp:CheckBox Checked="true"  class="checkbox checkbox-inline"  ID="CheckBox10" runat="server" Text="Yes"/>
            </td>
 <td  >
                Hard Disc Size</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox11" runat="server" Text="Yes"/>
            </td>
            <td  >
                Page Yield</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox29" runat="server" Text="Yes"/>
            </td>
 
        </tr>
        <tr>
            <td  >
                Warrenty Date To</td>
            <td>
                <asp:CheckBox Checked="true"  class="checkbox checkbox-inline"  ID="CheckBox12" runat="server" Text="Yes"/>
            </td>
 <td  >
                RAM Size</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox13" runat="server" Text="Yes"/>
            </td>
            <td  >
                Resolution (in pixel)</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox30" runat="server" Text="Yes"/>
            </td>

        </tr>
        <tr>
            <td  >
                AMC Date From</td>
            <td>
                <asp:CheckBox Checked="true"  class="checkbox checkbox-inline"  ID="CheckBox14" runat="server" Text="Yes"/>
            </td>
 <td  >
                Monitor</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox15" runat="server" Text="Yes"/>
            </td>
             <td>Wireless</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox31" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td  >
                AMC Date To</td>
            <td>
                <asp:CheckBox  Checked="true" class="checkbox checkbox-inline"  ID="CheckBox16" runat="server" Text="Yes"/>
            </td>
 <td  >
                System Architecture</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox17" runat="server" Text="Yes"/>
            </td>
            <td  >
                Night Vision</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox32" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td  >
                AMC Detail</td>
            <td>
                <asp:CheckBox  Checked="true" class="checkbox checkbox-inline"  ID="CheckBox18" runat="server" Text="Yes"/>
            </td>
 <td  >
                OS Architecture</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox19" runat="server" Text="Yes"/>
            </td>
<td  >
                Supported Standards</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox33" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td  >
                AMC Contact No</td>
            <td>
                <asp:CheckBox Checked="true"  class="checkbox checkbox-inline"  ID="CheckBox20" runat="server" Text="Yes"/>
            </td>
<td  >
                Screen Guard</td>
           <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox21" runat="server" Text="Yes"/>
            </td>
             <td  >
                Processor</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox34" runat="server" Text="Yes"/>
            </td>
        </tr>
        <tr>
            <td  >
                Serial No or Service Tag No</td>
            <td>
                <asp:CheckBox Checked="true"  class="checkbox checkbox-inline"  ID="CheckBox22" runat="server" Text="Yes"/>
            </td>
 <td  >
                Laptop Charger</td>
            <td>
                <asp:CheckBox class="checkbox checkbox-inline"  ID="CheckBox23" runat="server" Text="Yes"/>
            </td>
 <td >
                <asp:Button Width="200px" class="form-control" ID="Btn_Submit" runat="server"  Text="Save" 
                     BackColor="#9932cc" ForeColor="Yellow" onclick="Btn_Submit_Click"/>
            </td>
              <td>  <asp:Button  Width="200px"  class="form-control" ID="Btn_Cancel" runat="server" 
                Text="Reset" BackColor="#9932cc" ForeColor="Yellow" 
                    onclick="Btn_Cancel_Click"/>
            </td>
        </tr>
    
        
      
   </table>
                
       
        </asp:Panel>
        </center>
        </div>
     <center><h2>HARDWARE SPECIFICATIONS</h2></center>
    
<center>
 <div id="div1" style="width:1300px; max-height:700px; overflow:scroll;">
           
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="hardware_id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="hardware_id" HeaderText="ID" Visible="false"
                InsertVisible="False" ReadOnly="True" SortExpression="hardware_id" />
            <asp:BoundField DataField="hardware_name" HeaderText="NAME" 
                SortExpression="hardware_name" />
            <asp:CheckBoxField DataField="hardware_manufacturer" 
                HeaderText="MANUFACTURER" SortExpression="hardware_manufacturer" />
            <asp:CheckBoxField DataField="hardware_model" HeaderText="MODEL" 
                SortExpression="hardware_model" />
            <asp:CheckBoxField DataField="hardware_purchase_date" 
                HeaderText="PURCHASE DATE" SortExpression="hardware_purchase_date" />
            <asp:CheckBoxField DataField="hardware_purchase_file_number" 
                HeaderText="PURCHASE FILE NO" 
                SortExpression="hardware_purchase_file_number" />
            <asp:CheckBoxField DataField="hardware_warrenty_from" 
                HeaderText="WARRENTY FROM" SortExpression="hardware_warrenty_from" />
            <asp:CheckBoxField DataField="hardware_warrenty_to" 
                HeaderText="WARRENTY TO" SortExpression="hardware_warrenty_to" />
            <asp:CheckBoxField DataField="hardware_annual_maintenance_contract_from" 
                HeaderText="AMC FROM" 
                SortExpression="hardware_annual_maintenance_contract_from" />
            <asp:CheckBoxField DataField="hardware_annual_maintenance_contract_to" 
                HeaderText="AMC TO" 
                SortExpression="hardware_annual_maintenance_contract_to" />
            <asp:CheckBoxField DataField="hardware_annual_maintenance_contract_detail" 
                HeaderText="AMC DETAIL" 
                SortExpression="hardware_annual_maintenance_contract_detail" />
            <asp:CheckBoxField DataField="hardware_annual_maintenance_contract_number" 
                HeaderText="AMC NO" 
                SortExpression="hardware_annual_maintenance_contract_number" />
            <asp:CheckBoxField DataField="hardware_serial_no_or_service_tag_number" 
                HeaderText="SERIAL NO/SERVICE TAG NO" 
                SortExpression="hardware_serial_no_or_service_tag_number" />
            <asp:CheckBoxField DataField="hardware_mac_address" 
                HeaderText="MAC ADDRESS" SortExpression="hardware_mac_address" />
            <asp:CheckBoxField DataField="hardware_type" HeaderText="TYPE" 
                SortExpression="hardware_type" />
            <asp:CheckBoxField DataField="hardware_usb_support" 
                HeaderText="USB SUPPORT" SortExpression="hardware_usb_support" />
            <asp:CheckBoxField DataField="hardware_resolution" 
                HeaderText="RESOLUTION" SortExpression="hardware_resolution" />
            <asp:CheckBoxField DataField="hardware_night_vision" 
                HeaderText="NIGHT VISSION" SortExpression="hardware_night_vision" />
            <asp:CheckBoxField DataField="hardware_processor" 
                HeaderText="PROCESSOR" SortExpression="hardware_processor" />
            <asp:CheckBoxField DataField="hardware_graphics_card" 
                HeaderText="GRAPHICS CARD" SortExpression="hardware_graphics_card" />
            <asp:CheckBoxField DataField="hardware_dvd_writer" 
                HeaderText="DVD WRITER" SortExpression="hardware_dvd_writer" />
            <asp:CheckBoxField DataField="hardware_operating_system" 
                HeaderText="OS" 
                SortExpression="hardware_operating_system" />
            <asp:CheckBoxField DataField="hardware_keyboard" HeaderText="KEYBOARD" 
                SortExpression="hardware_keyboard" />
            <asp:CheckBoxField DataField="hardware_mouse" HeaderText="MOUSE" 
                SortExpression="hardware_mouse" />
            <asp:CheckBoxField DataField="hardware_hard_disc_size" 
                HeaderText="HDD SIZE" SortExpression="hardware_hard_disc_size" />
            <asp:CheckBoxField DataField="hardware_ram_size" HeaderText="RAM SIZE" 
                SortExpression="hardware_ram_size" />
            <asp:CheckBoxField DataField="hardware_monitor" HeaderText="MONITOR" 
                SortExpression="hardware_monitor" />
            <asp:CheckBoxField DataField="hardware_system_architecture" 
                HeaderText="SYSTEM ARCHITECTURE" 
                SortExpression="hardware_system_architecture" />
            <asp:CheckBoxField DataField="hardware_os_architecture" 
                HeaderText="OS ARCHITECTURE" 
                SortExpression="hardware_os_architecture" />
            <asp:CheckBoxField DataField="hardware_screen_guard" 
                HeaderText="HARDWARE SCREEN GUARD" SortExpression="hardware_screen_guard" />
            <asp:CheckBoxField DataField="hardware_laptop_charger" 
                HeaderText="LAPTOP CHARGER" SortExpression="hardware_laptop_charger" />
            <asp:CheckBoxField DataField="hardware_ups_rating" 
                HeaderText="UPS RATING" SortExpression="hardware_ups_rating" />
            <asp:CheckBoxField DataField="hardware_wire_length" 
                HeaderText="WIRE LENGTH" SortExpression="hardware_wire_length" />
            <asp:CheckBoxField DataField="hardware_page_yield" 
                HeaderText="PAGE YIELD" SortExpression="hardware_page_yield" />
            <asp:CheckBoxField DataField="hardware_wireless" HeaderText="WIRELESS" 
                SortExpression="hardware_wireless" />
            <asp:CheckBoxField DataField="hardware_supported_standards" 
                HeaderText="SUPPORTED STANDARDS" 
                SortExpression="hardware_supported_standards" />
        </Columns>
    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cn %>" 
        SelectCommand="SELECT * FROM [tb_hardware_specifications]" 
        DeleteCommand="DELETE FROM [tb_hardware_specifications] WHERE [hardware_id] = @hardware_id" 
        InsertCommand="INSERT INTO [tb_hardware_specifications] ([hardware_name], [hardware_manufacturer], [hardware_model], [hardware_purchase_date], [hardware_purchase_file_number], [hardware_warrenty_from], [hardware_warrenty_to], [hardware_annual_maintenance_contract_from], [hardware_annual_maintenance_contract_to], [hardware_annual_maintenance_contract_detail], [hardware_annual_maintenance_contract_number], [hardware_serial_no_or_service_tag_number], [hardware_mac_address], [hardware_type], [hardware_usb_support], [hardware_resolution], [hardware_night_vision], [hardware_processor], [hardware_graphics_card], [hardware_dvd_writer], [hardware_operating_system], [hardware_keyboard], [hardware_mouse], [hardware_hard_disc_size], [hardware_ram_size], [hardware_monitor], [hardware_system_architecture], [hardware_os_architecture], [hardware_screen_guard], [hardware_laptop_charger], [hardware_ups_rating], [hardware_wire_length], [hardware_page_yield], [hardware_wireless], [hardware_supported_standards]) VALUES (@hardware_name, @hardware_manufacturer, @hardware_model, @hardware_purchase_date, @hardware_purchase_file_number, @hardware_warrenty_from, @hardware_warrenty_to, @hardware_annual_maintenance_contract_from, @hardware_annual_maintenance_contract_to, @hardware_annual_maintenance_contract_detail, @hardware_annual_maintenance_contract_number, @hardware_serial_no_or_service_tag_number, @hardware_mac_address, @hardware_type, @hardware_usb_support, @hardware_resolution, @hardware_night_vision, @hardware_processor, @hardware_graphics_card, @hardware_dvd_writer, @hardware_operating_system, @hardware_keyboard, @hardware_mouse, @hardware_hard_disc_size, @hardware_ram_size, @hardware_monitor, @hardware_system_architecture, @hardware_os_architecture, @hardware_screen_guard, @hardware_laptop_charger, @hardware_ups_rating, @hardware_wire_length, @hardware_page_yield, @hardware_wireless, @hardware_supported_standards)" 
        UpdateCommand="UPDATE [tb_hardware_specifications] SET [hardware_name] = @hardware_name, [hardware_manufacturer] = @hardware_manufacturer, [hardware_model] = @hardware_model, [hardware_purchase_date] = @hardware_purchase_date, [hardware_purchase_file_number] = @hardware_purchase_file_number, [hardware_warrenty_from] = @hardware_warrenty_from, [hardware_warrenty_to] = @hardware_warrenty_to, [hardware_annual_maintenance_contract_from] = @hardware_annual_maintenance_contract_from, [hardware_annual_maintenance_contract_to] = @hardware_annual_maintenance_contract_to, [hardware_annual_maintenance_contract_detail] = @hardware_annual_maintenance_contract_detail, [hardware_annual_maintenance_contract_number] = @hardware_annual_maintenance_contract_number, [hardware_serial_no_or_service_tag_number] = @hardware_serial_no_or_service_tag_number, [hardware_mac_address] = @hardware_mac_address, [hardware_type] = @hardware_type, [hardware_usb_support] = @hardware_usb_support, [hardware_resolution] = @hardware_resolution, [hardware_night_vision] = @hardware_night_vision, [hardware_processor] = @hardware_processor, [hardware_graphics_card] = @hardware_graphics_card, [hardware_dvd_writer] = @hardware_dvd_writer, [hardware_operating_system] = @hardware_operating_system, [hardware_keyboard] = @hardware_keyboard, [hardware_mouse] = @hardware_mouse, [hardware_hard_disc_size] = @hardware_hard_disc_size, [hardware_ram_size] = @hardware_ram_size, [hardware_monitor] = @hardware_monitor, [hardware_system_architecture] = @hardware_system_architecture, [hardware_os_architecture] = @hardware_os_architecture, [hardware_screen_guard] = @hardware_screen_guard, [hardware_laptop_charger] = @hardware_laptop_charger, [hardware_ups_rating] = @hardware_ups_rating, [hardware_wire_length] = @hardware_wire_length, [hardware_page_yield] = @hardware_page_yield, [hardware_wireless] = @hardware_wireless, [hardware_supported_standards] = @hardware_supported_standards WHERE [hardware_id] = @hardware_id">
        <DeleteParameters>
            <asp:Parameter Name="hardware_id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="hardware_name" Type="String" />
            <asp:Parameter Name="hardware_manufacturer" Type="Boolean" />
            <asp:Parameter Name="hardware_model" Type="Boolean" />
            <asp:Parameter Name="hardware_purchase_date" Type="Boolean" />
            <asp:Parameter Name="hardware_purchase_file_number" Type="Boolean" />
            <asp:Parameter Name="hardware_warrenty_from" Type="Boolean" />
            <asp:Parameter Name="hardware_warrenty_to" Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_from" 
                Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_to" Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_detail" 
                Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_number" 
                Type="Boolean" />
            <asp:Parameter Name="hardware_serial_no_or_service_tag_number" Type="Boolean" />
            <asp:Parameter Name="hardware_mac_address" Type="Boolean" />
            <asp:Parameter Name="hardware_type" Type="Boolean" />
            <asp:Parameter Name="hardware_usb_support" Type="Boolean" />
            <asp:Parameter Name="hardware_resolution" Type="Boolean" />
            <asp:Parameter Name="hardware_night_vision" Type="Boolean" />
            <asp:Parameter Name="hardware_processor" Type="Boolean" />
            <asp:Parameter Name="hardware_graphics_card" Type="Boolean" />
            <asp:Parameter Name="hardware_dvd_writer" Type="Boolean" />
            <asp:Parameter Name="hardware_operating_system" Type="Boolean" />
            <asp:Parameter Name="hardware_keyboard" Type="Boolean" />
            <asp:Parameter Name="hardware_mouse" Type="Boolean" />
            <asp:Parameter Name="hardware_hard_disc_size" Type="Boolean" />
            <asp:Parameter Name="hardware_ram_size" Type="Boolean" />
            <asp:Parameter Name="hardware_monitor" Type="Boolean" />
            <asp:Parameter Name="hardware_system_architecture" Type="Boolean" />
            <asp:Parameter Name="hardware_os_architecture" Type="Boolean" />
            <asp:Parameter Name="hardware_screen_guard" Type="Boolean" />
            <asp:Parameter Name="hardware_laptop_charger" Type="Boolean" />
            <asp:Parameter Name="hardware_ups_rating" Type="Boolean" />
            <asp:Parameter Name="hardware_wire_length" Type="Boolean" />
            <asp:Parameter Name="hardware_page_yield" Type="Boolean" />
            <asp:Parameter Name="hardware_wireless" Type="Boolean" />
            <asp:Parameter Name="hardware_supported_standards" Type="Boolean" />
            <asp:Parameter Name="hardware_id" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="hardware_name" Type="String" />
            <asp:Parameter Name="hardware_manufacturer" Type="Boolean" />
            <asp:Parameter Name="hardware_model" Type="Boolean" />
            <asp:Parameter Name="hardware_purchase_date" Type="Boolean" />
            <asp:Parameter Name="hardware_purchase_file_number" Type="Boolean" />
            <asp:Parameter Name="hardware_warrenty_from" Type="Boolean" />
            <asp:Parameter Name="hardware_warrenty_to" Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_from" 
                Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_to" Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_detail" 
                Type="Boolean" />
            <asp:Parameter Name="hardware_annual_maintenance_contract_number" 
                Type="Boolean" />
            <asp:Parameter Name="hardware_serial_no_or_service_tag_number" Type="Boolean" />
            <asp:Parameter Name="hardware_mac_address" Type="Boolean" />
            <asp:Parameter Name="hardware_type" Type="Boolean" />
            <asp:Parameter Name="hardware_usb_support" Type="Boolean" />
            <asp:Parameter Name="hardware_resolution" Type="Boolean" />
            <asp:Parameter Name="hardware_night_vision" Type="Boolean" />
            <asp:Parameter Name="hardware_processor" Type="Boolean" />
            <asp:Parameter Name="hardware_graphics_card" Type="Boolean" />
            <asp:Parameter Name="hardware_dvd_writer" Type="Boolean" />
            <asp:Parameter Name="hardware_operating_system" Type="Boolean" />
            <asp:Parameter Name="hardware_keyboard" Type="Boolean" />
            <asp:Parameter Name="hardware_mouse" Type="Boolean" />
            <asp:Parameter Name="hardware_hard_disc_size" Type="Boolean" />
            <asp:Parameter Name="hardware_ram_size" Type="Boolean" />
            <asp:Parameter Name="hardware_monitor" Type="Boolean" />
            <asp:Parameter Name="hardware_system_architecture" Type="Boolean" />
            <asp:Parameter Name="hardware_os_architecture" Type="Boolean" />
            <asp:Parameter Name="hardware_screen_guard" Type="Boolean" />
            <asp:Parameter Name="hardware_laptop_charger" Type="Boolean" />
            <asp:Parameter Name="hardware_ups_rating" Type="Boolean" />
            <asp:Parameter Name="hardware_wire_length" Type="Boolean" />
            <asp:Parameter Name="hardware_page_yield" Type="Boolean" />
            <asp:Parameter Name="hardware_wireless" Type="Boolean" />
            <asp:Parameter Name="hardware_supported_standards" Type="Boolean" />
        </InsertParameters>
    </asp:SqlDataSource>
                
        </div>
  </center>
  </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

