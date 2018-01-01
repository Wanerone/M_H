<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="FanjuGuochanMore.aspx.cs" Inherits="Web.FanjuGuochan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div>
            <ul class="nav navbar-nav navbar-right" > 
                <li style="color:lightpink;">
                    <asp:LinkButton ID="LinkButton1" runat="server" BackColor="#3DC7BE"  >请登录</asp:LinkButton></li> 
                <li ><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/WebT.aspx">&nbsp;&nbsp;</asp:LinkButton></li> 
            </ul> 
                </div>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
        .biaoqian{
            width:100%;
            height:75px;
        }
        .biao{
            float:left;
            width:75px;
        }
        .qian{
            float:left;
            width:50%;
            font-size:x-large;
            padding-top:14px;
            height:70px;
        }
        .content{
            width:100%;
            padding-top:30px;
            margin-bottom:30px;
            
        }
        .trsty{
            margin:15px 10px;
             height:300px;
             overflow:hidden;
        }
        .tdsty{
            margin:15px 10px;
            width:97%;
            border:1px solid #404969;
            box-shadow: 0 0 7px rgba(0, 0, 0, .37);
            overflow:hidden;
        }
        .tu{
            width:27%;
            float:left;
             overflow:hidden;
        }
        .neirong{
            width:70%;
            float:left;
        }
        .nei{
            width:100%;
            height:30px;
        }
        .nei a{
            color:#90A4AE;
        }
        .nei1 a{
            font-size:xx-large;
            color:#393E46;
            text-decoration:none;
        }
        .nei1 a:hover{
            color:#0881A3;
        }
        .nei2{
            width:100%;
            height:100px;
            overflow:hidden;
        }
        .nei3{
            width:100%;
            height:20px;
        }
        .list-tu{
            float:left;
            width:30%;
                line-height: 21px;
             white-space: nowrap;
        }
        .list-tu img{
            vertical-align: top;
            margin-right: 5px;
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
         .clear{
             clear:both;
         }
          .tuijian{
            height:340px;
            border:1px solid ;
            margin-top:5px;
            border-style:none;
            cursor: pointer;
            overflow: hidden;
        }
        .ziti{
            width:200px;
            overflow: hidden;
            white-space: nowrap;
            text-overflow: ellipsis;
            color:#140303;
            opacity:1.0;
        }
        .ziti2{
            width:300px;
        }

        .tuijian a{
            transition: 0.3s;
            text-decoration:none;
            color:#140303;
            font-size:20px;
        }
        .tuitui img{
            border-radius: 5px;
            transition: 0.3s;
        }
        .tuitui img:hover{
            opacity: 0.7;
        }
        .tuijian a:hover{
            color:#00B8C0;
        }
          .bantou-paihang{
      
        }
        .bantou a{
            color:#2C2E3E;
            height:33px;
            text-decoration:none;
        }
        .bantou a:hover{
            color:#00B8C0;
        }
        .tubiao{
            float:left;
            height:340px;
            width:10%;
        }
        .tubiao tr{
            height: 40px;
        }
        .tubiao img{
            width:84%;
            height:25px;
        }
        .paihang{
            text-align:left!important;
            float:left;
            width:90%;
            height:340px;
        }
        .tuiji {
            height: 430px;
        }
    </style>
    <div class="biaoqian">
            <div class="biao">  <img  src="Tubiao/标签.png" width="70" height="70" /></div>
            <div class="qian">
                <asp:Label ID="Label1" runat="server" >国产原创</asp:Label>
            </div>
        </div>
    <div class="content">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <div class="col-lg-8">
            <asp:ListView ID="ListView1" runat="server" GroupItemCount="1">
                  <LayoutTemplate>      
                        <table  style="width:100%;">
                            <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                        </table>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <tr class="trsty">
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td class="tdsty">
                            <div class="tu"><a  href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>">
                           <img  src="<%# Eval("anime_Image")%>" class=" img-rounded" width="184"  height="269"/>
                               </a></div>
                            <div class="neirong">
                                <div class="nei1"><a   href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>"><%#Eval("anime_Name") %></a></div>
                                <div class="nei"><a>地区：</a><%#Eval("location") %></div>
                                <div class="nei"><a>年代：</a><%#Eval("addtime") %></div>
                                <div class="nei"><a>标签：</a><%#Eval("label") %></div>
                                <div class="nei2"><a>简介：</a><%#Eval("jianjie") %></div>
                                <div class="nei3">
                                    <div class="list-tu"><img src="Tubiao/观看1.png" width="20" height="20"/><span><%#Eval("readCount") %></span></div>
                                    <div class="list-tu"><img src="Tubiao/收藏2 .png" width="20" height="20" /><span><%#Eval("collection") %></span></div>
                                </div>
                            </div>
                        </td>
                        </ItemTemplate>
            </asp:ListView>
            <div class="datapager">
               <asp:DataPager ID="dpUser" class="pager" PagedControlID="ListView1"  runat="server" PageSize="6">
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
        </div>
                    </ContentTemplate>
        </asp:UpdatePanel>
        <div class="col-lg-4">
             <div class="bantou bantou-paihang" id="ssection-1"><a  href="#" style="font-size:30px;">热门排行</a><a href="#" style=" text-align:center; float:right;font-size:18px;margin-top:10px;">更多<<</a></div>
            <div class="tuijian tuiji">
                    <div class="tubiao">
                        <table>
                            <tr>
                                <td><img src="Image/数字1.png"/></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字2.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字3.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字4.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字5.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字6.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字7.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字8.png" /></td>
                            </tr>
                            <tr>
                                <td><img src="Image/数字9.png" /></td>
                            </tr>
                        </table>
                    </div>
                <div class="paihang">
                    <asp:ListView ID="ListView2" runat="server" GroupItemCount="1" >
                    <LayoutTemplate>      
                        <table>
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
                   <div class="ziti ziti2" style="padding: 6px; text-align:left;"> <a href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>" style="font-size:20px;" > <%#Eval("anime_Name") %></a>
                      </div>
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
                    </div>
            </div>
            <hr/>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>
