<%@ Page Title="" Language="C#" MasterPageFile="~/UserCenter.master" AutoEventWireup="true" CodeBehind="GeRenZhuYe.aspx.cs" Inherits="Web.GeRenZhuYe" %>
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
    </style>
<script src="js/jquery.min.js"></script>

    <div class="tou"><span>个人主页</span></div>
    <div class="ziliao">
        <asp:ListView ID="ListView1" runat="server">
                    <LayoutTemplate>      
                        <table  class="table table-condensed" style="margin-left:50px;">
                            <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                        </table>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <tr  >
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td style="height:100px;font-size:x-large;">
                            性  别:<%#Eval("sex") %>
                            </br>
                            生  日:<%#Eval("birthday", "{0:yyyy-MM-dd}") %>
                            </br>
                            住  址:<%#Eval("addr") %>
                            </br>
                            个性签名:<div style="word-wrap:break-word;word-break:break-all; height:150px;width:700px;padding-left:47px;border: #DED5C4 1px solid;"><%#Eval("perSign") %></div>
                        </td>
                    </ItemTemplate>
                        </asp:ListView>
    </div>
</asp:Content>
