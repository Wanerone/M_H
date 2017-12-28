<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayVideo.aspx.cs" Inherits="Web.PlayVideo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script runat="server">
    </script>
    <style type="text/css">
        .ch {
            color: #2B2B2B;
        }

        .ch2 {
            color: gray;
        }

        .en {
            color: #555555;
        }

        .ch:hover {
            color: steelblue;
        }

        .ch2:hover {
            color: steelblue;
        }

        .en:hover {
            color: #3366cc;
        }
    </style>
    <script type="text/javascript">
        function setVideo() {
           <%-- var vdhf = document.getElementById('<%=VDHF.ClientID%>');--%>
            var vdhf = document.getElementById("VDHF");
            var vid = document.getElementById("vid");
            vid.src = vdhf.value;

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
            <div style="clear: both; margin-bottom: 30px; overflow: hidden;">
                <div style="width: 1080px; margin-top: 15px; border-radius: 3px; padding-top: 10px; overflow: hidden;">
                    <div style="padding: 5px; float: left; width: 8%; border-bottom: 2px solid steelblue; overflow: hidden;" onclick="titleClick(1)">
                        <asp:HyperLink ID="kcLink" runat="server" CssClass="ch" Text="视频播放" NavigateUrl="#" Font-Names="微软雅黑" Font-Size="16" Font-Underline="false"></asp:HyperLink>
                    </div>                 
                </div>
                
                <div style="margin-top: 10px; font-family: 'Microsoft YaHei';">
                     <div id="left" style="width: 68%; border-right: 2px solid #e3e3e5; float: left; overflow: hidden; margin-right: 0px; margin-bottom:-3000px; padding-bottom:3000px;">

                        <div style="text-align: center; color: #2b2b2b; font-size: 18px;">
                            <asp:Label ID="txtTitle" runat="server" Text='<%#Eval("Vid_title") %>' ForeColor="#2b2b2b" Font-Size="18"></asp:Label>
                        </div>
                        <div style="text-align: center; padding: 5px; font-size: 14px; font-family: 'Microsoft YaHei'; color: #555555;">
                            <span style="padding-right: 10px;">上传时间：<asp:Label ID="txtCreateTime" runat="server" Text=""></asp:Label>
                            </span>

                        </div>
                        <div style="text-align: center; margin-top: 15px;">
                           <video id="vid"   autoplay="autoplay"  controls="controls"   preload="none"  height="350" width="600" >

                           </video>                           
                            <asp:HiddenField ID="VDHF" runat="server" />                    
                        </div>
                    </div>

                    <div id="right" style="float: left; margin-left: 10px; width: 28%; overflow: hidden; color: #555555;">
                        <div style="border-left: 3px solid #3366cc; padding-left: 5px; font-family: 'Microsoft YaHei'; color: #2b2b2b;">
                           
                        </div>
                    </div>
                </div>

            </div>
        </ContentTemplate>
        </asp:UpdatePanel>
        <script>
        setVideo();
    </script>
    </form>
</body>
</html>
