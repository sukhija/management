<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script src='https://www.google.com/recaptcha/api.js'></script>

    <marquee style="vertical-align:middle;" onmouseover="this.stop()" scrollamount="15" onmouseout="this.start()" visible="false" runat="server" id="successMsg">
            <span style="color:Green; font-size:xx-large;"> 
               Congractulations, You are successfully done your signup process now you have to wait for confirmation from admin.
            </span></marquee>
   <!------------------------------------LOGIN START---------------------------------->
<form id="loginForm" runat="server" method="post"> 
 
         <div id="div_login">
               
          
          <div id="signupbox" margin-top:50px" class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title"> Sign Up </div>
                            <div style="float:right; font-size: 85%; position: relative; top:-10px"><a id="signinlink" 
                            href="signin.aspx">Sign In</a></div>
                        </div>  
                        <div class="panel-body form-horizontal ">
                           
                                
                                <div id="signupalert" visible="false" class="alert alert-danger" runat="server">
                                    <p>Error: <asp:Label ID="Label2" runat="server"></asp:Label></p>
                                    <span></span>
                                </div>
                                    
                                
                                  
                                <div class="form-group"><div align="right" style="color:Red; font-size:x-small;">(*) mandatory fields</div>
                                <label for="firstname" class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox1" ID="RequiredFieldValidator4" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        First Name:</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox1" runat="server" class="form-control" name="username" placeholder="First Name"/>
                                        
                                    </div>
                                </div>
                                
                               
                                    
                                <div class="form-group">
                                    <label for="lastname" class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox2" ID="RequiredFieldValidator2" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Last Name:</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox2" runat="server" type="text" class="form-control" name="lastname" placeholder="Last Name"/>
                                        
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="email" class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox3" ID="RequiredFieldValidator5" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Email</label>
                                    <div class="col-md-9">
                                        <asp:TextBox type="text" ID="TextBox3" runat="server" class="form-control" name="email" placeholder="Email Address"/>
                                        <asp:RegularExpressionValidator ControlToValidate="TextBox3" ErrorMessage="Invalid Email Address"  
                                        ID="RegularExpressionValidator1" runat="server" Enabled="True" Display="Dynamic"
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                                         
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="password" class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox4" ID="RequiredFieldValidator6" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Password</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox4" runat="server" class="form-control" name="passwd" placeholder="Password" TextMode="Password" />
                                        
                                        
                                    </div>
                                </div>
                                    
                                <div class="form-group">
                                    <label for="password" class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox9" ID="RequiredFieldValidator7" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Confirm Password</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox9" runat="server" class="form-control" name="passwd" placeholder="Confirm Password" TextMode="Password" />
                                        
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Value must match with password" ControlToValidate="TextBox9"
                                        ControlToCompare="TextBox4" Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>
                                    </div>
                                </div>
                                
                                <div class="form-group">
                                    <label class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox5" ID="RequiredFieldValidator8" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Postal Address</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox5" runat="server" type="text" class="form-control" name="address" placeholder="Postal Address"/>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox6" ID="RequiredFieldValidator9" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Mobile Number</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox6" runat="server" type="text" class="form-control" name="mobile_no" placeholder="Mobile Number"/>
                                        
                                       <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                             ControlToValidate="TextBox6" ErrorMessage="Must be a valid 10 digit mobile no (without country code)" 
                                             ValidationExpression="[0-9]{10}" Display="Dynamic" SetFocusOnError="true"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="TextBox7" ID="RequiredFieldValidator10" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>Extention Number</label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="TextBox7" runat="server" type="text" class="form-control" name="extention_no" placeholder="Extention Number"/>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                             ControlToValidate="TextBox7" ErrorMessage="Enter a valid extention number(seperated by comma if more than one)" 
                                             ValidationExpression="^\d+(,\d+)*$" Display="Dynamic" SetFocusOnError="true"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Date of Birth</label>
                                    <div class="col-md-9">
                                        <input type="date" min="1955-01-01" max="2020-01-01" value="1955-01-01" class="form-control" name="datepicker" placeholder="Date of Birth" id="TextBox8" />
                                        
                                    </div>
                                </div>
                                
                                <div class="form-group">
                                    <label class="col-md-3 control-label"><asp:RequiredFieldValidator ControlToValidate="DropDownList1" ID="RequiredFieldValidator12" runat="server" 
                                        Text="*" Display="Dynamic" InitialValue="-1" SetFocusOnError="True"></asp:RequiredFieldValidator>Gender</label>
                                    <div class="col-md-9">
                                        <asp:DropDownList ID="DropDownList1" class="form-control" runat="server" AppendDataBoundItems="true">
                                            <asp:ListItem Text="Select" Selected="True" Value="-1"></asp:ListItem>
                                            <asp:ListItem>Male</asp:ListItem>
                                            <asp:ListItem>Female</asp:ListItem>
                                            <asp:ListItem>Other</asp:ListItem>
                                        </asp:DropDownList>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    
                                    <label class="col-md-3 control-label">
                                    <asp:RequiredFieldValidator ControlToValidate="FileUpload1" ID="RequiredFieldValidator13" runat="server" 
                                        Text="*" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        Profile Picture</label>
                                    <div class="col-md-9">
                                        <asp:FileUpload ID="FileUpload1" runat="server" class="form-control" placeholder="Profile Picture"/>
                                        
                                    </div>
                                </div>
                                
                                <div class="form-group">
                                    <label class="col-md-3 control-label">CAPTCHA</label>
                                    <div class="col-md-9">
                                        <div id="Div1" runat="server" class="g-recaptcha" data-sitekey="6LfM3hITAAAAAFZypx5xzvn_beIeqXCOS2iTg13m"></div><%--MY PUBLIC KEY--%>
                                        <asp:Label ID="lblGoogleReCaptcha" runat="server" ></asp:Label>
                                    </div>
                               </div>
                               
                         
                                <div style="margin-top:10px" class="form-group">
                                     <div class="col-sm-12 controls">
                                        <asp:Button ID="btnsignup" runat="server" Text="Sign up" class="btn btn-primary" OnClick="btnsignup_Click"/>
                                         <asp:Label ID="Label1" runat="server"></asp:Label>
                                     </div>
                                </div>   
                                 
                                
                                
                         </div>
                    </div>

               
               
                
         </div> 
         
         <%--------------------------------END SIGNUP-----------------------------------%>
         </div>
   
</form>
         <%--------------------------END SIGNIN AND SIGNUP-----------------------------------%>
  
</asp:Content>

