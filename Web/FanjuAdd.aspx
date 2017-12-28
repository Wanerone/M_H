<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FanjuAdd.aspx.cs" Inherits="Web.FanjuAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <h4>封面</h4> <asp:FileUpload ID="FileUpload1" runat="server" />
        <h4>链接</h4> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <h4>简介</h4><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <h4>年代</h4> <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <h4>地点</h4><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
       <h4>标签/类型</h4><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="确认" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
