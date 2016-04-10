<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgotpassword.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="forgotPasswordForm" runat="server" method="post"> 
 <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
         <div id="div_forgotPassword">
             
         <%--------------------------------START SIGNIN-----------------------------------%>
            
          <div id="forgotPasswordBox" style="margin-top:50px;" class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
              <asp:Label ID="Label_msg" runat="server" Font-Size="X-Large"></asp:Label>
            <div class="panel panel-info" runat="server" id="div_forgot_box">
                    <div class="panel-heading">
                        <div class="panel-title">Have you forgotten your password?</div>
                        <div style="float:right; font-size: 80%; position: relative; top:-10px">
                        <a href="signin.aspx">Back to Sign In</a></div>
                    </div>     

                    <div style="padding-top:30px" class="panel-body form-horizontal" >
                    <span>If you cannot remember your password, you can request that an alternative password be sent to your registered e-mail address.</span>
                        <div runat="server" style="display:none" id="forgotPassword_alert" class="alert alert-danger col-sm-12"></div>
                            
                                    
                                <div style="margin-bottom: 0px;" class="input-group" title="Enter Username">
                                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                            <input id="login_username" runat="server" type="text" class="form-control" name="tbusername" 
                                            value="" placeholder="Enter email" /> 
                                        
                                </div>
                                
                                <div style="margin-bottom: 25px;">
                                   <asp:RequiredFieldValidator ControlToValidate="login_username" ID="RequiredFieldValidator4" runat="server" 
                                      Display="Dynamic" ErrorMessage="Email cannot be empty" SetFocusOnError="True" Font-Size="Small">
                                 </asp:RequiredFieldValidator>
                                 <asp:RegularExpressionValidator ControlToValidate="login_username" ErrorMessage="Enter valid Email Address"  
                                        ID="RegularExpressionValidator1" runat="server" Enabled="True" Display="Dynamic" Font-Size="Small"
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                                </div>
                                
                                
                                    
                               

                                <div style="margin-top:10px" class="form-group">
                                     <div class="col-sm-12 controls">
                                        <asp:Button ID="btnRequestPwd" runat="server" Text="Request Password" class="btn btn-primary" OnClick="btnRequestPwd_Click"/>
                                     </div>
                                </div>


                                <div class="form-group">
                                        <div class="col-md-12">
                                            <div style="border-top: 1px solid#888; padding-top:15px; font-size:85%" >
                                                *Password will be reset and you will receive an email from 'developer.csio@gmail.com' at your registered email id. The email will contain new login credentials.
                                                <br />*Make sure you check spam and junk folders as well. 
                                           
                                            </div>
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

