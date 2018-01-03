<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebF.aspx.cs" Inherits="Web.WebF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div>
            <ul class="nav navbar-nav navbar-right" > 
                <li style="color:lightpink;">
                    <asp:HyperLink ID="HyperLink2" runat="server" BackColor="#3DC7BE">请登录</asp:HyperLink>
                </li> 
                <li >
                    <asp:HyperLink ID="HyperLink1" runat="server" Visible="False"></asp:HyperLink></li> 
            </ul> 
                </div>  
</asp:Content>