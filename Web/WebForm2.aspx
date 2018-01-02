<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <asp:ListView ID="ListView1" runat="server"  GroupItemCount="1">
                    <LayoutTemplate>      
                        <table style="margin:auto;" class="img-responsive">
                            <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                        </table>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <tr style="padding-top:10px;" >
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td  style="padding:5px;">
                            <%#Eval("Art_title") %>
                            <br />
                            <br />
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
    </form>
</body>
</html>
