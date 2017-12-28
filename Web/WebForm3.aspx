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
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
              
                <h3><asp:Label ID="Label8" runat="server"></asp:Label>评论</h3>
        <div class="pinlun">
            <div class="pin"><asp:Image ID="Image2" runat="server" CssClass="img-circle" /></div>
            <div class="lun">
               <div class="tb"><asp:TextBox ID="TextBox1" runat="server" width="98%" height="70px" TextMode="MultiLine"></asp:TextBox></div> 
                <div><asp:Button ID="Button3" runat="server" Text="发表评论" Height="70" Width="11%"  onclick="Button3_Click"/><span style="display: inline;" ><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator></span></div>
            </div>
        </div>
                <div class="content">
                    
                    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                            <div class="pinlun" >
                                <div class="pin"><img src="<%#Eval("headimg") %>" class="img-circle"/></div>
                                <div class="con">
                                    <h5><%#Eval("userName") %></h5>
                                    <h5><%#Eval("ComContent") %></h5>
                                    <ul class="ulstyle">
                                        <li>
                                            #<asp:Label ID="Label19" runat="server" ></asp:Label>
                                            </li>
                                        <li>
                                            <%#Eval("ComTime") %></li>
                                        <li>
                                            <asp:Label ID="PinglunZan" runat="server" ></asp:Label></li>
                                        <li>
                                            <asp:LinkButton ID="LinkButton1" runat="server"  CausesValidation="false" OnClick="LinkButton1_Click">回复</asp:LinkButton> </li>
                                    </ul>
                                </div>
                            </div>
                            <asp:Panel ID="Panel1" runat="server" Visible="false">
                                <div class="pinlun">
                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("ArticleComment_id") %>' />
                                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("ArticleComment_id") %>' Visible="false"></asp:Label>
                                    <div class="pin"><asp:Image ID="Image3" runat="server" CssClass="img-circle" /></div>
                                    <div class="lun">
                                        <div class="tb"><asp:TextBox ID="TextBox2" runat="server" width="98%" height="100px" TextMode="MultiLine"></asp:TextBox></div>   
                                        <asp:Button ID="Button1" runat="server" Text="回复" CausesValidation="False"  OnClick="Button4_Click"/>
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                    <div class="con" style="padding-left: 93px; padding-top: 10px;">
                                        <h5><%#Eval("aftername") %> ..回复.. <%#Eval("beforename") %><a style="padding-left: 15px;"><%#Eval("ReplyContent") %></a></h5>
                                        <ul class="ulstyle">
                                            <li>
                                                <%#Eval("ReplyTime") %></li>
                                            <li>
                                                <asp:Label ID="PinglunZan" runat="server" ></asp:Label></li>
                                            <li>
                                                <asp:LinkButton ID="LinkButton2" runat="server"  CausesValidation="false" OnClick="LinkButton1_Click">回复</asp:LinkButton> </li>
                                        </ul>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
