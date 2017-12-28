<%@ Page Title="" Language="C#" MasterPageFile="~/Creation.Master" AutoEventWireup="true" CodeBehind="CreationArt.aspx.cs" Inherits="Web.CreationArt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div>
            <ul class="nav navbar-nav navbar-right" > 
                <li><asp:LinkButton ID="LinkButton1" runat="server" ></asp:LinkButton></li> 
                <li style="color:#F86254!important;"><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/WebT.aspx">退出</asp:LinkButton></li> 
            </ul> 
                </div>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
