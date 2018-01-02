<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Music.aspx.cs" Inherits="Web.Music" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <style>
        .search1{
            width: 40%;
            margin: 0 auto;
        }
        .inputt {
          width: 90%;
          height: 42px;
          padding-left: 10px;
          border: 2px solid #7BA7AB;
          border-radius: 5px;
          outline: none;
          background: #F9F0DA;
          color: #9E9C9C;
        }
        .buttonn {
           
          float:right;
          top: 0;
          right: 0px;
          width: 42px;
          height: 42px;
          border: none;

          border-radius: 0 5px 5px 0;
          cursor: pointer;
        }
        .buttonn:before {

          font-size: 16px;
          color: #F9F0DA;
        }
    </style>
    <script type="text/javascript">
       
        function Clear() {
            document.getElementById("<%=txtKeyword.ClientID%>").value = "";
        }
        function Get() {
            document.getElementById("<%=txtKeyword.ClientID%>").value = "看你所看..";
        }

    </script>
    <div class="search1">
            <asp:TextBox ID="txtKeyword" runat="server" CssClass="inputt" Text="看你所看.." onclick="Clear();" onblur="Get();" ></asp:TextBox>
	        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="buttonn" ImageUrl="~/Tubiao/搜索.png" />
    </div>

</asp:Content>
