<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Web.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="100%">
        <tr>
            <th colspan="3">
                <asp:Label ID="lblTitle" runat="server"></asp:Label></th>
        </tr>
        <tr>
            <th>
                账号</th>
            <td>
                <asp:TextBox ID="tbMajorId" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvMajorId" runat="server" ControlToValidate="tbMajorId"
                    Text="*" ErrorMessage="账号不能为空！" SetFocusOnError="true"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <th>
                密码</th>
            <td>
                <asp:TextBox ID="tbMajorName" runat="server" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvMajorName" runat="server" ControlToValidate="tbMajorName"
                    Text="*" ErrorMessage="用户密码不能为空！" SetFocusOnError="true"></asp:RequiredFieldValidator></td>
        </tr>        
        <tr>
            <td colspan="3" align="right">
                <asp:LinkButton ID="lbtnSave" runat="server" Text="保存" OnClick="lbtnSave_Click"></asp:LinkButton>
                <asp:LinkButton ID="lbtnCancel" runat="server" Text="返回" CausesValidation="false"
                    PostBackUrl="~/UserBrower.aspx" ></asp:LinkButton>
            </td>
        </tr>
    </table>
    <asp:ValidationSummary ID="vs" runat="server" ShowMessageBox="true" ShowSummary="false" />
    </div>
    </form>
</body>
</html>
