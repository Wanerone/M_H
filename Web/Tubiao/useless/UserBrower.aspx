<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserBrower.aspx.cs" Inherits="Web.UserBrower" %>

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
            <td>
                <asp:Label ID="lblTitle" runat="server" Text="没有任何专业！"></asp:Label>
            </td>
            <td align="right">
                <asp:LinkButton ID="lbtnAdd" runat="server" PostBackUrl="~/Edit.aspx" Text="增加新专业" OnClick="lbtnAdd_Click"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                
                
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="账号">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("UserID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="密码">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:HyperLinkField DataNavigateUrlFields="UserID" DataNavigateUrlFormatString="~/Edit.aspx?UserID={0}" HeaderText="修改" Text="查看" />
                        <asp:TemplateField HeaderText="删除">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("UserID") %>' CommandName="MyDelete" Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                
                
                
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
