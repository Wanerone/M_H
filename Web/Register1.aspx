<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegister.Master" AutoEventWireup="true" CodeBehind="Register1.aspx.cs" Inherits="Web.Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="odiv">
            <div id="div1"></div>
            <div id="div3">注册</div>
            <div id="div2"></div>
        </div>
       <div id="register" style="padding-left:400px;">
           <table>
                <tr>
                <td style="height: 39px; width: 610px;">
                    <asp:Label ID="Label1" runat="server" Text="邮箱注册：" Font-Size="Medium"></asp:Label>
                    &nbsp; &nbsp;
                    <asp:TextBox ID="TextEmail" runat="server" Height="33px" Width="237px" style="margin-left: 0"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextEmail" ErrorMessage="*" ForeColor="Red" Font-Size="Medium" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextEmail" ErrorMessage="邮箱格式错误" Font-Size="Medium" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:Label ID="Labelcheckemail" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Label ID="Label8" runat="server"  ForeColor="Red"></asp:Label>
                </td>
            </tr>
             <tr>
                <td style="height: 39px; width: 610px;">
                    <asp:Label ID="Label4" runat="server" Text="用户名："></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextUser" runat="server" Height="33px" Width="238px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextUser" ErrorMessage="*" ForeColor="Red" Font-Size="Medium" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:Label ID="Labelcheckuser" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Label ID="Label9" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td style="height: 39px; width: 610px;">
                    <asp:Label ID="Label2" runat="server" Text="密码：" Font-Size="Medium"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextPassword" runat="server" Height="33px" Width="238px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextPassword" ErrorMessage="*" ForeColor="Red" Font-Size="Medium"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextPassword" ErrorMessage="密码不超过12位" Font-Size="Medium" ForeColor="Red" Display="Dynamic" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td style="height: 39px; width: 610px;">
                    <asp:Label ID="Label3" runat="server" Text="确认密码：" Font-Size="Medium"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextPassword2" runat="server" Height="33px" Width="238px" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="不一致" ForeColor="Red" ControlToCompare="TextPassword" ControlToValidate="TextPassword2" Font-Size="Medium"></asp:CompareValidator>
                 </td>
            </tr>
               <tr>
                   <td style="height: 39px; width: 610px;">
                       <asp:Label ID="Label11" runat="server" Text="密保问题：" Font-Size="Medium"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                       <asp:TextBox ID="TextBox1" runat="server" Height="33px" Width="238px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="请输入密保问题！" ControlToValidate="TextBox1" ForeColor="Red" Font-Size="Medium">*</asp:RequiredFieldValidator>
                   </td>
               </tr>
                <tr>
                   <td style="height: 39px; width: 610px;">
                       <asp:Label ID="Label12" runat="server" Text="密保答案：" Font-Size="Medium"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                       <asp:TextBox ID="TextBox2" runat="server" Height="33px" Width="238px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="请输入密保问题！" ControlToValidate="TextBox2" ForeColor="Red" Font-Size="Medium">*</asp:RequiredFieldValidator>
                   </td>
               </tr>
             <tr>
                <td style="height: 39px; width: 610px;">
                    <asp:Label ID="Label5" runat="server" Text="验证码："></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextCheck" runat="server" Height="24px"></asp:TextBox>
                        <asp:Image ID="Image1" runat="server" Height="22px" Width="72px" ImageUrl="~/CheckCode.aspx" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextCheck" ErrorMessage="*" ForeColor="Red" Font-Size="Medium"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label6" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td style="height: 39px; width: 610px;">
                    <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="注册" Width="98px" Font-Size="Medium" ForeColor="White" BackColor="#66CCFF" BorderColor="#3399FF" BorderStyle="Solid" /></td>
            </tr>
            <tr>
                <td style="height: 39px; width: 610px;">
                    <a href="Login.aspx">已有账号，赶紧登陆</a>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 44px; width: 610px;">
                </td>
            </tr>
           </table>
       </div>
</asp:Content>
