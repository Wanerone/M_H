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
                            <div class="tu"><a  href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>">
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
