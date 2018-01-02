<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Web.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
      <div style="font-family: 'Microsoft YaHei'; color: #2b2b2b;">

            <div class="title_top">
                <asp:Label ID="Label5" runat="server" Text="教学视频-添加视频" Font-Size="15" Font-Names="微软雅黑" ForeColor="#ffffff"></asp:Label>
            </div>
            <div style="margin-top: 15px;">
                <span>
                    <asp:Label ID="Label1" runat="server" Text="视频标题"></asp:Label>
                </span>
                <span>
                    <asp:TextBox ID="VideoTitle" runat="server" MaxLength="20" Width="200"></asp:TextBox>
                </span>
                <span>
                    <asp:Label ID="Label2" runat="server" Text="(不超过20个字符)"  ForeColor="#555555" Font-Size="10"></asp:Label>
                </span>
            </div>
            <div style="margin-top: 15px;">
                <span>
                    <asp:Label ID="Label3" runat="server" Text="视频文件"></asp:Label>
                </span>
                <span>
                    <asp:FileUpload ID="FileVideo" runat="server" />
                </span>
                 <span>
                    <asp:Label ID="Label6" runat="server" Text="(若视频前台无法播放,请上传MP4格式视频)"  ForeColor="#555555" Font-Size="10"></asp:Label>
                </span>
            </div>
            <div style="margin-top: 15px;">
                <span>
                    <asp:Label ID="Label4" runat="server" Text="视频截图"></asp:Label>
                </span>
                <span>
                    <asp:FileUpload ID="FileScreen" runat="server" />
                <br />
                简介：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                类别:<asp:Label ID="Label7" runat="server" Text="动漫"></asp:Label>
                </span>
            </div>
            <div style="margin-left: 220px; margin-top: 15px;">
                <asp:Button ID="Button1" runat="server" Text="添加" BorderStyle="None" BackColor="#72839D" Style="border-radius:2px; cursor:pointer; font-family:'Microsoft YaHei'; padding:3px; color:white;" OnClick="Button1_Click" />
            </div>
          
        </div>
    </div>
    </form>
</body>
</html>
