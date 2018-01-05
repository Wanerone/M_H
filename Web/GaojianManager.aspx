<%@ Page Title="" Language="C#" MasterPageFile="~/Creation.Master" AutoEventWireup="true" CodeBehind="GaojianManager.aspx.cs" Inherits="Web.GaojianManager" %>
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
        .content{
            width:100%;
            height:auto;
            border:0.5px #DDDDDD solid;
        }
        .article{
            margin:30px 15px;
            height:auto;
           
        }
        .video{
            margin:50px 15px;
            height:auto;
            
        }
         .biaoqian{
            width:100%;
            height:55px;
        }
        .biao{
            float:left;
            width:55px;
        }
        .qian{
            float:left;
            width:50%;
            font-size:x-large;
            padding-top:14px;
            height:50px;
        }
        .ziti{
             width:200px;
            overflow: hidden;
            white-space: nowrap;
            text-overflow: ellipsis;
        color:#140303;
        opacity:1.0;

       }
        .tuijian a{
    transition: 0.3s;
    text-decoration:none;
    color:#140303;
    font-size:20px;
        }
         .tuijian a:hover{
            color:#00B8C0;
        }
         <!--datapager-->
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
    <div class="content">
    <div class="article">
       <div class="biaoqian">
            <div class="biao">  <img  src="Tubiao/文章.png" width="50" height="50" /></div>
            <div class="qian">
                我的文章(<asp:Label ID="Label1" ForeColor="#F6490D" runat="server" ></asp:Label>)
            </div>
        </div>
        <div class="article1">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserCnnString %>" SelectCommand="SELECT * FROM [Article] where email=@email" DeleteCommand="delete from Article where Art_id=@Art_id">
                <DeleteParameters>
                    <asp:Parameter Name="Art_id" />  
                </DeleteParameters>
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="Email" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3" DataKeyNames="Art_id">
                <AlternatingItemTemplate>
                    <td  runat="server">
                  <div class="tuijian" style="height:150px; width:240px;">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 200px;">
                           <a  href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>">
                           <img  src="<%# Eval("Art_image")%>" class=" img-rounded" width="200"  height="100"/>
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>"> <%#Eval("Art_title") %></a></div>
                      </div>
                        <div style="width:200px;"><asp:Button ID="DeleteButton" runat="server" CssClass="btn btn-info " Height="35" Width="200" CommandName="Delete" onclientclick="return confirm('确认删除？')" Text="删除" /></div>
                        <br /></td>
                </AlternatingItemTemplate>

                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td ><h3 style="color:#476268;">您还未发表任何文章。</h3></td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
<td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                
                <ItemTemplate>
                    <td  runat="server">
                  <div class="tuijian"  style="height:150px; width:240px;">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 200px;">
                           <a  href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>">
                           <img  src="<%# Eval("Art_image")%>" class=" img-rounded" width="200"  height="100"/>
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>"> <%#Eval("Art_title") %></a></div>
                      </div>
                      <div style="width:200px;"><asp:Button ID="DeleteButton" runat="server" CssClass="btn btn-info " Height="35" Width="200" CommandName="Delete" onclientclick="return confirm('确认删除？')" Text="删除" /></div>
                        <br /></td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server"  >
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" >
                              <div class="datapager">
               <asp:DataPager ID="dpUser" class='pager' PagedControlID="ListView1"  runat="server" PageSize="6">
                         <Fields>                       
                         
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
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <td  runat="server">
                  <div class="tuijian" style="height:150px; width:240px;">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 200px;">
                           <a  href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>">
                           <img  src="<%# Eval("Art_image")%>" class=" img-rounded" width="200"  height="100"/>
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "ArticleDisplay.aspx?id="+ Eval("Art_id") %>"> <%#Eval("Art_title") %></a></div>
                      </div>
                        <div style="width:200px;"><asp:Button ID="DeleteButton" runat="server" CssClass="btn btn-info" Height="35" Width="200" CommandName="Delete" onclientclick="return confirm('确认删除？')" Text="删除" /></div>
                        
                        <br /></td>
                </SelectedItemTemplate>
            </asp:ListView>
        </div>
    </div>
    <div class="video">
          <div class="biaoqian">
            <div class="biao">  <img  src="Tubiao/视频.png" width="50" height="50" /></div>
            <div class="qian">
                我的视频(<asp:Label ID="Label2" ForeColor="#F6490D" runat="server" ></asp:Label>)
            </div>
        </div>
       <div class="video1">

           <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:UserCnnString %>" DeleteCommand="delete from Video where Vid_id=@Vid_id" SelectCommand="select * from Video where email=@email">
               <DeleteParameters>
                   <asp:Parameter Name="Vid_id" />
               </DeleteParameters>
               <SelectParameters>
                   <asp:SessionParameter Name="email" SessionField="Email" />
               </SelectParameters>
           </asp:SqlDataSource>
           <asp:ListView ID="ListView2" runat="server" DataSourceID="SqlDataSource2" GroupItemCount="3" DataKeyNames="Vid_id">
                <AlternatingItemTemplate>
                    <td  runat="server">
                  <div class="tuijian" style="height:150px; width:240px;">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 200px;height:100px;overflow:hidden;">
                         <a  href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>">
                           <img  src="<%# Eval("Vid_img")%>" class=" img-rounded" />
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>"> <%#Eval("Vid_title") %></a></div>
                      </div>
                        <div style="width:200px;"><asp:Button ID="DeleteButton" runat="server" CssClass="btn btn-info " Height="35" Width="200" CommandName="Delete" onclientclick="return confirm('确认删除？')" Text="删除" /></div>
                        <br /></td>
                </AlternatingItemTemplate>

                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td><h3 style="color:#476268;">您还未发表任何文章。</h3></td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
<td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                
                <ItemTemplate>
                    <td  runat="server">
                  <div class="tuijian" style="height:150px; width:240px;">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 200px;height:100px;overflow:hidden;">
                         <a  href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>">
                           <img  src="<%# Eval("Vid_img")%>" class=" img-rounded" />
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>"> <%#Eval("Vid_title") %></a></div>
                      </div>
                        <div style="width:200px;"><asp:Button ID="DeleteButton" runat="server" CssClass="btn btn-info " Height="35" Width="200" CommandName="Delete" onclientclick="return confirm('确认删除？')" Text="删除" /></div>
                        <br /></td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server"  >
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" >
                              <div class="datapager">
               <asp:DataPager ID="dpUser2" class='pager' PagedControlID="ListView2"  runat="server" PageSize="6">
                         <Fields>                       
                         
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
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                <td  runat="server">
                  <div class="tuijian" style="height:150px; width:240px;">
                       <div style="margin: 5px;border: 1px solid #ccc; float: left; width: 200px;height:100px;overflow:hidden;">
                         <a  href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>">
                           <img  src="<%# Eval("Vid_img")%>" class=" img-rounded" />
                               </a></div>
                   <div class="ziti" style="padding: 5px;text-align: center;"> <a href="<%# "VideoDisplay.aspx?id="+ Eval("Vid_id") %>"> <%#Eval("Vid_title") %></a></div>
                      </div>
                        <div style="width:200px;"><asp:Button ID="DeleteButton" runat="server" CssClass="btn btn-info " Height="35" Width="200" CommandName="Delete" onclientclick="return confirm('确认删除？')" Text="删除" /></div>
                        <br /></td>
                </SelectedItemTemplate>
            </asp:ListView>
       </div>
    </div>
        </div>
</asp:Content>
