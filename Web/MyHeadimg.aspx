<%@ Page Title="" Language="C#" MasterPageFile="~/UserCenter.master" AutoEventWireup="true" CodeBehind="MyHeadimg.aspx.cs" Inherits="Web.MyHeadimg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
        .tou{
                width:100%;
                height: 50px;
                padding-left: 30px;
                padding-top:15px;
                border-bottom: 1px solid #ddd;
        }
        .tou span{
                border-left: #ec6690 5px solid;
                padding-left:5px;               
                color: #00a1d6;
                font-size: 18px;
                cursor: default;
        }
        .zhuti{
            margin:20px 300px;
        }
        .xiugai{
            padding:50px 60px;
        }
        .baocun{
            padding:30px 60px;
        }

    </style>
     <div class="tou"><span>我的头像</span></div>
    <div class="zhuti">
        <div class="imgtou">
            <asp:Image ID="Image1" runat="server" Width="200" Height="200"  CssClass="img-circle" />
        </div>
        <div  class="xiugai">
         <asp:FileUpload ID="FileUpload1" runat="server" />

        </div>
        <div  class="baocun">
            <asp:button runat="server"  Text="保存" CssClass="btn-lg" ForeColor="#00A1D6" OnClick="Unnamed1_Click" /></div>
    </div>
</asp:Content>
