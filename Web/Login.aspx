<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegister.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="odiv">
            <div id="div1"></div>
            <div id="div3">登录</div>
            <div id="div2"></div>
        </div>
        <div id="bleft" style="border-style:hidden;">
            <div class="img" style="padding-left:90px;padding-top:50px;" >
                <img src="Image/nongyu.jpg" class="img-rounded" alt="Cinque Terre" />
            </div>

        </div>
        <div id="bright" style="border-style:hidden;">
                <div style="padding-top:50px;padding-left:50px;">
                    <div class="glyphicon glyphicon-user">                      
                        <asp:TextBox ID="UserName" runat="server" BorderColor="#C2D6CF" BorderStyle="Solid" Height="38px" Width="287px" BackColor="#A0DBDB"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="UserName" Display="Dynamic" ErrorMessage="账户不为空!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                        </div>
                    <br />
                    <br />
                    <br />
                    <div class="glyphicon glyphicon-th-large">
                        
                        <asp:TextBox ID="Password" runat="server" TextMode="Password" BorderColor="#C2D6CF" BorderStyle="Solid" Height="38px" Width="287px" BackColor="#A0DBDB"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Password" Display="Dynamic" ErrorMessage="密码不为空!" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </div>
                    <br />
                    <br />
                    <br />
                    <div class="glyphicon glyphicon-text-width">
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="#A0DBDB" BorderColor="#C2D6CF" BorderStyle="Solid" Height="38px"></asp:TextBox>
                        &nbsp;
                        <asp:Image ID="Image1" runat="server" Height="22px" Width="72px" ImageUrl="~/CheckCode.aspx"  />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="请输入验证码!" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </div>
                    <br />
                    <br />
                    <div id="remmber" style="width:287px;">
                        <div class="one" style="float:left;">
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="记住我" OnCheckedChanged="CheckBox1_CheckedChanged" />
                        </div>
                        <div class="two" style="float:right;">
                            <a href="#">忘记密码?</a></div>
                    </div>
                    <br />
                    <br />
                    <div id="dengl" style="width:287px;">
                        <div class="denglv" style="float:left;"><asp:Button ID="Button2" runat="server" BackColor="#A0DBDB" Height="47px" Text="登录" Width="100px" BorderColor="#C6C6C6" BorderStyle="Solid" OnClick="Button2_Click" /></div>
                        <div class="zhuce" style="float:right;"><asp:Button ID="Button3" runat="server"  Height="47px" Text="注册" Width="100px" BorderColor="#C6C6C6" BorderStyle="Solid" CausesValidation="False" PostBackUrl="~/Register1.aspx" /></div>
                    </div>
                </div>
            </div>
</asp:Content>
