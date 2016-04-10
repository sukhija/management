<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="EMPLOYEE_signin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
   <!------------------------------------LOGIN START---------------------------------->
<form id="loginForm" runat="server" method="post"> 
 <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
         <div id="div_login">
               
         <%--------------------------------START SIGNIN-----------------------------------%>
            
          <div id="loginbox" style="margin-top:50px;" class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
            <div class="panel panel-info" >
                    <div class="panel-heading">
                        <div class="panel-title">Sign In</div>
                        <div style="float:right; font-size: 80%; position: relative; top:-10px">
                        <a href="forgotpassword.aspx">Forgot password?</a></div>
                    </div>     

                    <div style="padding-top:30px" class="panel-body form-horizontal" >
                    
                        <div runat="server" style="display:none" id="login_alert" class="alert alert-danger col-sm-12"></div>
                            
                                    
                                <div style="margin-bottom: 0px;" class="input-group" title="Enter Username">
                                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                            <input id="login_username" runat="server" type="text" class="form-control" name="tbusername" 
                                            value="" placeholder="Enter email" /> 
                                        
                                </div>
                                
                                <div style="margin-bottom: 25px;">
                                   <asp:RequiredFieldValidator ControlToValidate="login_username" ID="RequiredFieldValidator4" runat="server" 
                                      Display="Dynamic" ErrorMessage="Email cannot be empty" SetFocusOnError="True" Font-Size="Small" ForeColor="Red">
                                 </asp:RequiredFieldValidator>
                                 <asp:RegularExpressionValidator ControlToValidate="login_username" ErrorMessage="Enter valid Email Address"  
                                        ID="RegularExpressionValidator1" runat="server" Enabled="True" Display="Dynamic" Font-Size="Small"
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                                </div>
                                
                                <div style="margin-bottom: 0px" class="input-group"  title="Enter Password">
                                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                            <input id="login_password" runat="server" type="password" class="form-control" name="tbpassword" placeholder="password"/>
                                </div>
                               
                                <div style="margin-bottom: 25px;">
                                <asp:Label ID="Label_Error" ForeColor="Red" runat="server" Visible="false" Text="Wrong Username or Password"></asp:Label>
                                   <asp:RequiredFieldValidator ControlToValidate="login_password" ID="RequiredFieldValidator1" runat="server" Font-Size="Small"
                                       Display="Dynamic" ErrorMessage="Password cannot be empty" SetFocusOnError="True" ForeColor="Red">
                                 </asp:RequiredFieldValidator>
                                </div>
                                    
                                <div class="input-group">
                                          <div class="checkbox">
                                            <label>
                                              <input id="login-remember" type="checkbox" name="remember" value="1"/> Remember me
                                            </label>
                                          </div>
                                </div>

                                <div style="margin-top:10px" class="form-group">
                                     <div class="col-sm-12 controls">
                                        <asp:Button ID="btnlogin" runat="server" Text="Sign in" class="btn btn-primary" OnClick="btnlogin_Click"/>
                                        
                                     </div>
                                </div>


                                <div class="form-group">
                                        <div class="col-md-12">
                                            <div style="border-top: 1px solid#888; padding-top:15px; font-size:85%" >
                                                Don't have an account! 
                                           <a href="signup.aspx" >
                                                Sign Up Here
                                            </a>
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
         <%--------------------------END SIGNIN AND SIGNUP-----------------------------------%>
  
</asp:Content>

