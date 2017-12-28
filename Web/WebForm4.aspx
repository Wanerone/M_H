<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Web.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                    评论<span>审核中</span>

                         
                           <asp:TextBox ID="FCKeditor1" runat="server" TextMode="MultiLine" Height="68px" Width="736px"></asp:TextBox>

                        <asp:Button ID="pinglun" runat="server" Text="发布评论"  OnClick="pinglun_Click"/><span style="display: inline;" class="error_tip fr"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FCKeditor1" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator></span>

                    
       <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                    
                                               <a class="author js_user"><%#Eval("UserName") %></a>
                                               <%#Eval("ComContent") %></div>
                                                <%#string.Format("{0:yyyy-MM-dd HH:mm}",Eval("ComTime")) %>
                                                   <asp:LinkButton ID="LinkButton1" runat="server" CssClass="link_reply js_expand_reply" CausesValidation="false" OnClick="LinkButton1_Click">回复<span></span></asp:LinkButton>
                                           <asp:Panel ID="Panel1" runat="server" Visible="false">
                                                            <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("ArticleComment_id") %>' />
                                                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("ArticleComment_id") %>' Visible="false"></asp:Label>
                                                           <asp:TextBox ID="FCKeditor2" runat="server" TextMode="MultiLine" Height="44px" Width="590px" ></asp:TextBox>             
                                                           <asp:Button ID="Button1" runat="server" CssClass="btn_comment js_btn_reply" CausesValidation="false" OnClick="BttLogin_Click" Text="回复" />
                                               </asp:Panel>        
                          </dd>
                     
                </dl>
            </div>
                 <asp:Repeater ID="Repeater2" runat="server">
                         <ItemTemplate>
                                    <%#Eval("aftername") %></a>回复 <a class="author js_user"><%#Eval("beforename") %></a>

                                               <%#Eval("ReplyContentt") %>
                                         <%#string.Format("{0:yyyy-MM-dd HH:mm}",Eval("ReplyTime")) %>

                                               </div>
                                            </div>
                                            </dd>
                                            </dl>
                                            </div>
                        </ItemTemplate>
                            </asp:Repeater>
                 </ItemTemplate>
                  </asp:Repeater>
</ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
