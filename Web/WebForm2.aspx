<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                            <asp:Label ID="txtTitle" runat="server" Text='<%#Eval("Vid_title") %>' ForeColor="#2b2b2b" Font-Size="18"></asp:Label>
<video id="vid"     controls="controls"   preload="none"  height="350" width="600" >

                           </video>
                           
                            <asp:HiddenField ID="VDHF" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
