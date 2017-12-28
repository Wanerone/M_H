<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="VideoDisplay.aspx.cs" Inherits="Web.VideoDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .image img{
            width:100%;
            height:auto;
        }
        .ulstyle{
            padding-left:5px;
        }
        .title{
            margin:10px 0;
        }
        .ulstyle li{
            display:inline;
            margin-right:20px;
            color:#6E828A;
        }
        .content{
            padding-top:10px;
        }
         .userinfo{
            width:100%;   
             padding-top:50px;
            height:auto;
             border:0.5px solid #808080;
            border-style:none;
            border-bottom-style:solid;
            text-align:center;     
        }
        .tongji{
            padding-top:10px;
            width:100%;
            height:100px;
        }
        .tongji a{
            text-decoration:none;
        }
        .tongji a:hover{
            color:#00B8C0;
        }
        .guanzhu{
            width:50%;
            text-align:center;
            float:left;
        }
        .imagee{
            
            width:40%;
            float:left;
        }
        .imagee img{
            width:100%;
            height:auto;
        }
        .titlee{
            float:left;
            width:60%;
            height:auto;
        }
        .titlee a{
            font-size:medium;
              color:#140303;
              text-decoration:none;
              margin-left:5px;
        }
        .titlee a:hover{
            color:#00B8C0;
        }
        .pinlun {
            width: 100%;
            padding-top: 30px;
            height: 100px;
        }
        .pin {
            width: 10%;
            height: auto;
            float: left;
            height: 70px;
        }
        .pin img{
            width: 70%;
            height: 60px;
        }

        .lun {
            width: 88%;
            height: auto;
            float: left;
        }
        .tb {
            float: left;
            width: 88%;
        }
        .con {
            width: 90%;
        }
        #praise {
            display: block;
            width: 40px;
            height: 40px;
            margin: 0 auto;
        }
        .praise {
            width: 40px;
            height: 40px;
            margin: 50px auto;
            cursor: pointer;
            font-size: 12px;
            text-align: center;
            position: relative;
        }
        .praise img {
            width: 40px;
            height: 40px;
            display: block;
            margin: 0 auto;
        }
        #praise-txt {
            height: 25px;
            line-height: 25px;
            display: block;
        }
    </style>
     <div class="row">
    <div class="col-lg-9">
         <div class="display">
             <div class="title"><asp:Label ID="Label1" runat="server" CssClass="h1" Font-Bold="True"></asp:Label></div>
             <ul class="ulstyle">
                 <li>
                     <asp:Label ID="Label2" runat="server" ></asp:Label></li>
                 <li>
                     <asp:Label ID="Label3" runat="server" ></asp:Label></li>
                 <li>
                     <asp:Label ID="Label4" runat="server" ></asp:Label></li>
                 <li>
                     <asp:Label ID="Label5" runat="server" ></asp:Label></li>
                 <li>
                     <asp:Label ID="Label6" runat="server" ></asp:Label></li>
             </ul>
             <div class="content">
                 <asp:ListView ID="ListView1" runat="server">
                     <LayoutTemplate>      
                         <table  style="width:100%">
                             <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                         </table>
                     </LayoutTemplate>
                     <GroupTemplate>
                         <tr  >
                             <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                         </tr>
                     </GroupTemplate>
                     <ItemTemplate>
                         <td >
                             <div style="width:100%;">
                                 <video width="800" height="600" controls="">
                                     <source src="<%#Eval("Vid_url") %>" type="video/mp4"/>
                                 </video>
                             </div>
                             <div style="padding-top:20px;">
                                 <p>简介:<a><%#Eval("Vid_jianjie") %></a></p>   
                             </div>
                         </td>
                     </ItemTemplate>
                 </asp:ListView>
                 
                 </div>

    </div>
        
        </div>
    <div class="col-lg-3" >
        <div class="user">
            <div class="userinfo">
            <asp:ListView ID="ListView2" runat="server">
                    <LayoutTemplate>      
                        <table  style="width:100%">
                            <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                        </table>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <tr  >
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td >
                            <div style="width:100%;">
                                <img src="<%#Eval("headimg") %>"  class="img-circle " width="120" height="120" style="margin:0 auto;"/>
                            </div>
                            <div style="height:50px;padding-top:10px;text-align:center;">
                                <p style="text-align:center;font-size:large;color:#40A798;"><%#Eval("userName") %></p>
                            </div>
                        </td>
                    </ItemTemplate>
                        </asp:ListView>
                </div>
             <div class="tongji">
            <a class="guanzhu" href="#"><p style="color:#90A4AE;">文章数</p>
                <p style="color:#140303">10</p>
            </a>
            <a class="guanzhu" href="#"><p style="color:#90A4AE">粉丝数</p>
                <p style="color:#140303">10</p>
            </a>
        </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="关注" CssClass="btn-block img-rounded" BackColor="#A1EAFB"  BorderStyle="None" Font-Size="Large" /></div>
        </div>
        <div class="usermore">
            <h3>TA的更多文章</h3>
            <div>
                 <asp:ListView ID="ListView3" runat="server" >
                    <LayoutTemplate>      
                        <table style="margin:auto;" class="img-responsive">
                            <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                        </table>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <tr style="padding-top:10px;" >
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td  style="padding:5px;">
                            <div class="imagee">
                                <a href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>">
                                <img src="<%#Eval("Art_image")%>" class="img-rounded" /></a>
                            </div>
                            <div class="titlee"><a href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>"><%#Eval("Art_title") %></a></div>
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
            </div>
            <div style="padding-top:10px;">
                <asp:Button ID="Button2" runat="server" Text="查看更多" CssClass="btn-block img-rounded" BackColor="#A1EAFB"  BorderStyle="None" Font-Size="Large" /></div>
            </div>
        </div>
    </div>
</asp:Content>
