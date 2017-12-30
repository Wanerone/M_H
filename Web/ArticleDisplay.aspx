﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="ArticleDisplay.aspx.cs" Inherits="Web.ArticleDisplay" EnableEventValidation="false" %>
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
        .datapager{
            padding-top:40px;
            width:100%;
        }
          pager
         {
              margin:0 100px;
         display:block;
         padding: 5px 0;
         margin: 10px 0 10px 0;
          }
         .pager a, .pager span
         {      
          font-size:larger; 
         border: 1px solid #E6E7E1;
         line-height: 20px;
         margin-right: 5px;
         padding: 0 6px;
         color: #0046D5;
          }
         .pager a:hover
          {
         text-decoration: none;
         border-color: #0046D5;
         }
         .pager .current
         {
         background-color: #0046D5;
         border-color: #0046D5;
        color: #fff;
         font-weight: bold;
         }
         .pager .total, .pager .total strong
         {
         color: Gray;
         padding: 0 3px;
        }
    </style>
     <div class="row">
    <div class="col-lg-9">
         <div class="display">
             <div class="image"><asp:Image ID="Image1" runat="server" CssClass="img-rounded" /></div>
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
                 <asp:Label ID="Label7" runat="server" ></asp:Label>
                 </div>
    </div>
        
        <div style="padding-top: 30px;">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="praise">
                    <span id="praise"> <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" OnClick="ImageButton1_Click"  width="40" height="40"  /></span>
                    <span id="praise-txt" class=""><asp:Label ID="Label10" runat="server" ></asp:Label></span>
                </div>
                <h3><asp:Label ID="Label8" runat="server"></asp:Label>评论</h3>
        <div class="pinlun">
            <div class="pin"><asp:Image ID="Image2" runat="server" CssClass="img-circle" /></div>
            <div class="lun">
               <div class="tb"><asp:TextBox ID="TextBox1" runat="server" width="98%" height="70px" TextMode="MultiLine"></asp:TextBox></div> 
                <div><asp:Button ID="Button3" runat="server" Text="发表评论" Height="70" Width="11%"  onclick="Button3_Click"/><span style="display: inline;" ><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator></span></div>
            </div>
        </div>
                <div class="content">
                    
                    <asp:ListView ID="ListView1" runat="server" OnItemDataBound="ListView1_ItemDataBound">
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
                                        <div>
                                            <asp:Button ID="Button4" runat="server" Text="回复"  height="70" Width="11%" CausesValidation="False" OnClick="Button4_Click"/><span style="display: inline;" ><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator></span></div>     
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:ListView ID="ListView2" runat="server">
                                <ItemTemplate>
                                    <div class="con" style="padding-left: 93px; padding-top: 10px;">
                                        <h5><%#Eval("aftername") %> ..回复.. <%#Eval("beforename") %><a style="padding-left: 15px;"><%#Eval("ReplyContent") %></a></h5>
                                        <ul class="ulstyle">
                                            <li>
                                                <%#Eval("ReplyTime") %></li>
                                            <li>
                                                <asp:Label ID="PinglunZan" runat="server" ></asp:Label></li>
                                            <li>
                                                <asp:LinkButton ID="LinkButton2" runat="server"  CausesValidation="false" OnClick="LinkButton2_Click">回复</asp:LinkButton> </li>
                                        </ul>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="datapager">
               <asp:DataPager ID="dpUser" class='pager' PagedControlID="ListView1"  runat="server" PageSize="6">
                         <Fields>                       
                         <asp:TemplatePagerField>
                        <PagerTemplate>
                         <span class="total">共<strong><%=Math.Ceiling ((double)dpUser.TotalRowCount / dpUser.PageSize)%></strong>页<strong><%=dpUser.TotalRowCount%></strong>条记录</span>
                          </PagerTemplate>
                         </asp:TemplatePagerField>
                         <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="True" 
                         ShowNextPageButton="False" ShowPreviousPageButton="False" 
                         FirstPageText="首页" LastPageText="尾页" />
                         <asp:NumericPagerField ButtonCount="5" CurrentPageLabelCssClass="current" />
                         <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" 
                         ShowNextPageButton="False" ShowPreviousPageButton="False" 
                         FirstPageText="首页" LastPageText="尾页" />
                         </Fields>
                          </asp:DataPager>
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>
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
    <!--
<script>

    $(function(){
        $("#praise").click(function(){
            var praise_img = $("#praise-img");
            var praise_txt = $("#<%=Label1.ClientID%>");
            var num=parseInt(praise_txt.text());
            if (praise_img.attr("src") == ("Tubiao/收藏1.png")) {
                $(this).html("<img src='Tubiao/收藏.png' id='praise-img'/>");
                num -=1;
                praise_txt.text(num);
                $.ajax({
                    type: "post",
                    contentType: "application/json", //传值的方式
                    url: "FanjuDisplay.aspx/GetValueAjax", //WebAjaxForMe.aspx为目标文件，GetValueAjax为目标文件中的方法
                    data: "{num:'" + num + "'}", //username 为想问后台传的参数（这里的参数可有可无）
                    success: function(result) {
                        alert(result.d); //result.d为后台返回的参数
                    }
                });
            }else{
                $(this).html("<img src='Tubiao/收藏1.png' id='praise-img' />");
                num +=1;
                praise_txt.text(num);
                $.ajax({
                    type: "post",
                    contentType: "application/json", //传值的方式
                    url: "FanjuDisplay.aspx/GetValueAjax", //WebAjaxForMe.aspx为目标文件，GetValueAjax为目标文件中的方法
                    data: "{num:'" + num + "'}", //username 为想问后台传的参数（这里的参数可有可无）
                    success: function (result) {
                        alert(result.d); //result.d为后台返回的参数
                    }
                });
            }
        });
    })
</script>-->
</asp:Content>
