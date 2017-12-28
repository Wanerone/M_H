<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fabiaowenzhang.aspx.cs" Inherits="Web.WebForm5" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>  
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        发布文章<br />
        <br />
        标题:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        内容<br />
    
    <CKEditor:CKEditorControl ID="txtContent" runat="server" BasePath="ckeditor/" DefaultLanguage="zh-cn" Width="880" Height="600">
                </CKEditor:CKEditorControl>
        <br />
        <br />
        选择图片:<asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" />
        </div>
    </form>
</body>
</html>
