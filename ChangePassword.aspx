<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form id="loginForm" runat="server" method="post"> 
 <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
         <div id="div_change_pwd">
               
         <%--------------------------------START SIGNIN-----------------------------------%>
            
          <div id="div_change_pwd" style="margin-top:50px;" class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
                <asp:Label ID="Label_msg" runat="server" Font-Size="X-Large"></asp:Label>
            <div class="panel panel-info" runat="server" id="div_changePassword_box">
                    <div class="panel-heading">
                        <div class="panel-title">Change Password</div>
                        <div style="float:right; font-size: 80%; position: relative; top:-10px">
                        <a href="signin.aspx">Sign In</a></div>
                    </div>     

                    <div style="padding-top:30px" class="panel-body form-horizontal" >
                    
                        <div runat="server" style="display:none" id="login_alert" class="alert alert-danger col-sm-12"></div>
                            
                                    
                                <div style="margin-bottom: 0px;" class="input-group" title="Enter Password">
                                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                            <input id="reset_pwd" runat="server" type="password" class="form-control" name="tbpwd" 
                                            value="" placeholder="Enter Password" /> 
                                        
                                </div>
                                
                                <div style="margin-bottom: 25px;">
                                   <asp:RequiredFieldValidator ControlToValidate="reset_pwd" ID="RequiredFieldValidator4" runat="server" 
                                      Display="Dynamic" ErrorMessage="Password cannot be empty" SetFocusOnError="True" Font-Size="Small">
                                 </asp:RequiredFieldValidator>
                               </div>
                                
                                <div style="margin-bottom: 0px" class="input-group"  title="Confirm Password">
                                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                            <input id="reset_confirm_pwd" runat="server" type="password" class="form-control" name="tbConfirmPwd" placeholder="Confirm Password"/>
                                </div>
                               
                                <div style="margin-bottom: 25px;">
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" Font-Size="Small"
                                        ErrorMessage="Compare password must match with password" SetFocusOnError="true"
                                        ControlToCompare="reset_pwd" ControlToValidate="reset_confirm_pwd"></asp:CompareValidator>
                                        
                                   <asp:RequiredFieldValidator ControlToValidate="reset_confirm_pwd" ID="RequiredFieldValidator1" runat="server" Font-Size="Small"
                                       Display="Dynamic" ErrorMessage="Password cannot be empty" SetFocusOnError="True">
                                 </asp:RequiredFieldValidator>
                                </div>
                                    
                                

                                <div style="margin-top:10px" class="form-group">
                                     <div class="col-sm-12 controls">
                                        <asp:Button ID="btnChangePwd" runat="server" Text="Change Password" 
                                             class="btn btn-primary" onclick="btnChangePwd_Click" />
                                        
                                     </div>
                                </div>


                                   
                             
                    </div>                     
             </div>  
         </div>
            
        </div>
</ContentTemplate>
</asp:UpdatePanel>      
</form>



</asp:Content>

