<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Fanju.aspx.cs" Inherits="Web.Fanju" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
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
        .fanju{
            height:340px;
            border:1px solid ;
        }
        .yinyue{
            height:340px;
            border:1px solid ;
        }
        .youxi{
            height:340px;
            border:1px solid ;
        }
        .xiaoshuo{
            height:340px;
            border:1px solid ;
        }
        .bantou-paihang{
            padding-top:30px;
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
         .fan {
             width: 20%;
         }
        .image {
            width: 33%;
            height: 70px;
        }
        .image img {
            width:100%;
            height:auto;
        }
        .conten {
            padding-top: 30px;
        }
        .tuiji {
            height: 430px;
        }
        .fanjupai {
            height: 500px;
        }
        .shendan{
            width:100%;
            height:auto;
        }
        .shendan img{
            width:100%;
            margin:0 auto;
        }
       
             </style>
   <div id="myCarousel" class="carousel slide" >
    <!-- 轮播（Carousel）指标 -->
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>   
    <!-- 轮播（Carousel）项目 -->
    <div class="carousel-inner">
        <div class="item active">
            <img src="Image/1111.jpg" alt="First slide"/>
        </div>
        <div class="item">
            <img src="Image/22.jpg" alt="Second slide"/>
        </div>
        <div class="item">
            <img src="Image/33.jpg" alt="Third slide"/>
        </div>

    </div>
    <!-- 轮播（Carousel）导航 -->
    <a class="carousel-control left" href="#myCarousel" 
        data-slide="prev">&lsaquo;
    </a>
    <a class="carousel-control right" href="#myCarousel" 
        data-slide="next">&rsaquo;
    </a>
</div>
    <div class="conten">
        <div class="col-lg-8">
           <div class="bantou" id="section-1"><a href="#" style="font-size:30px;">最近更新</a><a href="FanjuZuijinMore.aspx" style="float:right;font-size:18px;margin-top:10px;">更多<<</a></div>
            <div class="tuijian tuitui" style="">
                <asp:ListView ID="ListView1" runat="server" GroupItemCount="3" >
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
                        <td >
                  <div style="height:auto">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 230px; height: 120px; overflow: hidden;">
                           <a  href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>">
                           <img  src="<%# Eval("anime_Image")%>" class=" img-rounded" width="230"  />
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>"> <%#Eval("anime_Name") %></a></div>
                      </div>
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
            </div>
            <hr/>
            <div class="bantou"><a href="#" style="font-size:30px;">国产原创</a><a href="#" style="float:right;font-size:18px;margin-top:10px;">更多<<</a></div>
            <div class="tuijian tuitui" style="">
                <asp:ListView ID="ListView3" runat="server" GroupItemCount="3" >
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
                        <td >
                            <div style="height:auto">
                                <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 230px; height: 120px; overflow: hidden;">
                                    <a  href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>">
                                        <img  src="<%# Eval("anime_Image")%>" class=" img-rounded" width="230"  />
                                    </a></div>
                                <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>"> <%#Eval("anime_Name") %></a></div>
                            </div>
                        </td>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <hr/>
            <div class="bantou"><a href="#" style="font-size:30px;">日漫强推</a><a href="#" style="float:right;font-size:18px;margin-top:10px;">更多<<</a></div>
            <div class="tuijian tuitui" style="">
                <asp:ListView ID="ListView4" runat="server" GroupItemCount="3" >
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
                        <td >
                            <div style="height:auto">
                                <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 230px; height: 120px; overflow: hidden;">
                                    <a  href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>">
                                        <img  src="<%# Eval("anime_Image")%>" class=" img-rounded" width="230"  />
                                    </a></div>
                                <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>"> <%#Eval("anime_Name") %></a></div>
                            </div>
                        </td>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <hr/>
            <div class="bantou"><a href="#" style="font-size:30px;">电影剧场版</a><a href="#" style="float:right;font-size:18px;margin-top:10px;">更多<<</a></div>
            <div class="tuijian tuitui" style="">
                <asp:ListView ID="ListView5" runat="server" GroupItemCount="3" >
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
                        <td >
                            <div style="height:auto">
                                <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 230px; height: 120px; overflow: hidden;">
                                    <a  href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>">
                                        <img  src="<%# Eval("anime_Image")%>" class=" img-rounded" width="230"  />
                                    </a></div>
                                <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>"> <%#Eval("anime_Name") %></a></div>
                            </div>
                        </td>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <hr/>

        </div>

         <div class="col-lg-4">
             <div class="shendan"><img src="Image/shengdan.jpg" class="img-rounded" /></div>
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
                   <div class="ziti ziti2" style="padding: 6px; text-align:left;"> <a style="font-size:20px;" href="<%# "FanjuDisplay.aspx?id="+ Eval("anime_ID") %>">  <%#Eval("anime_Name") %></a>
                      </div>
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
                    </div>
            </div>
            <hr/>
            <h2 id="ssection-2">热门资讯</h2>
            <div class="fanju fanjupai">

            </div>
            <hr/>    
           </div>
    </div>
        
</asp:Content>
