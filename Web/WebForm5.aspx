<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Web.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css" >
*{margin:0;padding:0;}
body{margin:10px;font-size:14px;font-family:宋体}
h1{font-size:26px;margin:10px 0 15px;}
#commentHolder{width:540px;border-bottom:1px solid #aaa;}
.comment{padding:5px 8px;background:#f8fcff;border:1px solid #aaa;font-size:14px;border-bottom:none;}
.comment p{padding:5px 0;}
.comment p.title{color:#1f3a87;font-size:12px;}
.comment p span{float:right;color:#666}
.comment div{background:#ffe;padding:3px;border:1px solid #aaa;line-height:140%;margin-bottom:5px;}
.comment div span{color:#1f3a87;font-size:12px;}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="50px" Width="98%">
                <table cellpadding="0" cellspacing="1" class="border" align="left">
                    <asp:Repeater ID="rptComment" OnItemCommand="rptComment_ItemCommand" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td class="bqright" style="width: 100%;">
                                    <table>
                                        <tr>
                                            <td style="width: 20%">
                                                回复人：<%# Eval("Staff_Name")%>
                                            </td>
                                            <td style="width: 20%">
                                                是否专家：<%# Eval("IsMaster")%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%">
                                                评论星级：<%#Eval("StarLevel")%>
                                            </td>
                                            <td style="width: 20%">
                                                评论人IP：<%#Eval("ReviewIP")%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                评分：<%#Eval("CommentScore")%>
                                            </td>
                                            <td>
                                                回复时间:<%#Eval("ReviewTime")%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table width="100%">
                                        <tr>
                                            <td>
                                                评论标题:
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 100%">
                                                <%# Eval("ReviewTitle")%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                评论内容：
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 100%">
                                                <%#(Eval("ReviewContent").ToString())%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:LinkButton ID="lnkbtnDel" runat="server" CommandArgument='<%#Eval("CID") %>'
                                                    CommandName="Del" OnClientClick="return confirm('是否删除此回复？')">删除</asp:LinkButton></td>
                                                    <td>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("CID") %>'
                                                    CommandName="Quote" >引用</asp:LinkButton></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Width="100%">
                <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td style="width: 12%; height: 22px;">
                            评分：</td>
                        <td style="width: 56%; height: 22px;">
                            <asp:TextBox ID="txtCommentScore" runat="server" Width="124px"></asp:TextBox><asp:RegularExpressionValidator
                                ID="RegularExpressionValidator19" runat="server" ControlToValidate="txtCommentScore"
                                ErrorMessage="输入money类型！" ValidationExpression="^\d{1,12}(?:\.\d{1,4})?$"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 12%">
                            评论星级：</td>
                        <td style="width: 56%">
                            <asp:DropDownList ID="ddlStarLevel" runat="server" Width="130px">
                                <asp:ListItem>--请选择--</asp:ListItem>
                                <asp:ListItem>★</asp:ListItem>
                                <asp:ListItem>★★</asp:ListItem>
                                <asp:ListItem>★★★</asp:ListItem>
                                <asp:ListItem>★★★★</asp:ListItem>
                                <asp:ListItem>★★★★★</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 12%">
                            是否专家：</td>
                        <td style="width: 56%">
                            <asp:CheckBox ID="cbIsMaster" runat="server" /></td>
                    </tr>
                    <tr>
                        <td style="width: 12%; height: 24px;">
                            评论标题：</td>
                        <td style="width: 100px; height: 24px;">
                            <asp:TextBox ID="txtReviewTitle" runat="server" Width="440px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 12%">
                            评论内容：</td>
                        <td style="width: 56%">
                            <asp:TextBox ID="txtReviewContent" runat="server" Height="152px" Width="440px" TextMode="MultiLine"></asp:TextBox><font
                                style="color: red">（请输入1000字以内的评论。）</font></td>
                    </tr>
                    <tr>
                        <td style="width: 12%">
                            <asp:Button ID="btnSutmit" runat="server" Text="提交" OnClick="btnSutmit_Click" /></td>
                        <td style="width: 56%">
                            <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click" /></td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
