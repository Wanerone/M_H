<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="FanjuDisplay.aspx.cs" Inherits="Web.FanjuDisplay"  EnableEventValidation="false"%>
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>

       .display {
           width: 100%;
           height: 300px;
       } 
       .Fanjuimage {
           width: 23%;
           height: 265px;
           float: left;
       }
       .Fanjuimage img {
           width: 100%;
           height: 100%;
       }
       .FanjuInfo {
           padding-left: 20px;
           width: 77%;
           float: left;
       }
       .d_label {
           width: 50%;
           float: left;
           color: #666;
           line-height: 1.6rem;
           padding-top: 10px;
       }
       .d_label2 {
           width: 100%;
           float: left;
           color: #777;
           line-height: 1.6rem;
           padding-top: 10px;
       }
       .xihuan {
           float: right;
       }
       .lee {
           margin-right: 5rem;
           line-height: 23px;
           display: inline-block;
           float: left;
           font-size: 14px;
           border-style: none;
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
           cursor: pointer;
           font-size: 12px;
           text-align: center;
           float: right;
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
       .lianjie {
           width: 100%;
           height: 80px;
       }
       .L_link {
           width: 33%;
           float: left;
           display: block;
       }
       .L_link a {
           padding-left: 30px;
           text-decoration: none;
           font-size: x-large;
           cursor: pointer;
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
       .youqing {
           width:100%;
           height: 50px;
           padding-left: 30px;
           padding-top:15px;
           border-bottom: 1px solid #ddd;
       }
       .youqing span{
           border-left: #ec6690 5px solid;
           padding-left:5px;               
           color: #00a1d6;
           font-size: 18px;
           cursor: default;
       }
       .tuijian{
           width: 100%;
           height:340px;
           border:1px solid ;
           margin-top:5px;
           border-style:none;
           cursor: pointer;
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
           width:90%;
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
            height: 55px;
        }

        .lun {
            width: 85%;
            height: auto;
            float: left;
        }
        .tb {
            float: left;
            width: 85%;
        }
        .bt{
            float:left;
            width:15%;
        }
        .con {
            width: 90%;
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
    </style>

         <div class="col-lg-8">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                <div class="display">
                <div class="Fanjuimage">
                    <asp:Image ID="Image1" runat="server" CssClass="img-rounded"  />
                </div>
                <div class="FanjuInfo">
                    <div style="color: darkgoldenrod; font-size: x-large;"> <asp:Label ID="Label1" runat="server"></asp:Label></div>
                    <div class="praise">
                        <span id="praise"> <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="false" OnClick="ImageButton1_Click"  width="40" height="40"  /></span>
                        <span id="praise-txt" class=""><asp:Label ID="Label3" runat="server" ></asp:Label></span>
                    </div>
                    <div class="d_label"><b>地区：</b><asp:Label ID="Label4" runat="server" ></asp:Label></div>
                    <div class="d_label"><b>年代：</b><asp:Label ID="Label5" runat="server" ></asp:Label></div>
                    <p></p>
                    <p></p>
                    <div class="d_label2"><b>标签：</b><asp:Label ID="Label6" runat="server" ></asp:Label></div>
                    <p></p>
                    <p></p>
                    <div class="d_label2"><b>简介：</b><asp:Label ID="Label7" runat="server" ></asp:Label></div><p></p>
                </div>
            </div>
                <div class="youqing"><span>马上去看</span></div>
                <div class="lianjie">
                   <div class="L_link"><a href="https://www.bilibili.com/">哔哩哔哩</a></div>
                    <div class="L_link"><a href="http://www.youku.com/">优酷</a></div>
                    <div class="L_link"><a href="http://www.dilidili.wang/">嘀哩嘀哩</a></div>
                </div>
        </ContentTemplate>
        </asp:UpdatePanel>
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                <h3><asp:Label ID="Label8" runat="server"></asp:Label>评论</h3>
        <div class="pinlun">
            <div class="pin"><asp:Image ID="Image2" runat="server" CssClass="img-circle" /></div>
            <div class="lun">
               <div class="tb"><asp:TextBox ID="TextBox1" runat="server" width="98%" height="70px" TextMode="MultiLine"></asp:TextBox></div> 
                <div class="bt"><asp:Button ID="Button3" runat="server" CssClass="btn-lg" Text="发表评论" Height="70"   onclick="Button3_Click"/><span style="display: inline;" ><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator></span></div>
            </div>
        </div>
                <div class="content">
                    
                    <asp:ListView ID="ListView1" runat="server" OnItemDataBound="ListView1_ItemDataBound">
                        <ItemTemplate>
                            <div class="pinlun" >
                                <div class="pin"><img src="<%#Eval("headimg") %>" class="img-circle"/></div>
                                <div class="con">
                                    <h5><%#Eval("userName") %></h5>
                                    <h5><a style="text-decoration:none;color:#000000;font-size:large;"><%#Eval("comment") %></a></h5>
                                    <ul class="ulstyle">
                                        <li>
                                            #<asp:Label ID="Label19" runat="server" ></asp:Label>
                                            </li>
                                        <li>
                                            <%#Eval("time") %></li>
                                        <li>
                                            <asp:Label ID="PinglunZan" runat="server" ></asp:Label></li>
                                        <li>
                                            <asp:LinkButton ID="LinkButton1" runat="server"  CausesValidation="false" OnClick="LinkButton1_Click">回复</asp:LinkButton> </li>
                                    </ul>
                                </div>
                            </div>
                            <asp:Panel ID="Panel1" runat="server" Visible="false">
                                <div class="pinlun">
                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("com_id") %>' />
                                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("com_id") %>' Visible="false"></asp:Label>
                                    <div class="pin"><asp:Image ID="Image3" runat="server" CssClass="img-circle" /></div>
                                    <div class="lun">
                                        <div class="tb"><asp:TextBox ID="TextBox2" runat="server" width="98%" height="100px" TextMode="MultiLine"></asp:TextBox></div>   
                                        <div>
                                            <asp:Button ID="Button4" runat="server" CssClass="btn-lg" Text="回复"  height="70" Width="11%" CausesValidation="False" OnClick="Button4_Click"/><span style="display: inline;" ><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator></span></div>     
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:ListView ID="ListView2" runat="server">
                                <ItemTemplate>
                                    <div class="con" style="padding-left: 93px; padding-top: 10px;">
                                        <h5><a style="text-decoration:none;color:#50595C;font-size:medium;"><%#Eval("aftername") %></a>  回复 <a style="text-decoration:none;color:#50595C;font-size:medium;"><%#Eval("beforename") %></a> <a style="padding-left: 15px;text-decoration:none;color:#000000;font-size:large;"><%#Eval("reply_content") %></a></h5>
                                        <ul class="ulstyle">
                                            <li>
                                                <%#Eval("reply_time") %></li>
                                            <li>
                                                <asp:Label ID="PinglunZan" runat="server" ></asp:Label></li>
                                            <li>
                                              
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
    <div class="col-lg-4">
    <div class="bantou" id="ssection-1"><a  href="#" style="font-size:30px;">排行</a><a href="#" style=" text-align:center; float:right;font-size:18px;margin-top:10px;">更多<<</a></div>
            <div class="tuijian">
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
                        </table>
                    </div>
                <div class="paihang">
                    <asp:ListView ID="ListView5" runat="server" GroupItemCount="1" >
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
                   <div class="ziti ziti2" style="padding: 6px; text-align:left;"> <a style="font-size:20px;" > <%#Eval("anime_Name") %></a>
                      </div>
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
                    </div>
            </div>
    </div>
    <div class="clear"></div>
</asp:Content>
