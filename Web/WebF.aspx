﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebF.aspx.cs" Inherits="Web.WebF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div>
            <ul class="nav navbar-nav navbar-right" > 
                <li style="color:lightpink;">
                    <asp:LinkButton ID="LinkButton1" runat="server" BackColor="#3DC7BE"  >请登录</asp:LinkButton></li> 
                <li ><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/WebT.aspx">&nbsp;&nbsp;</asp:LinkButton></li> 
            </ul> 
                </div>  
</asp:Content>