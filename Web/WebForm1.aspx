<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListView ID="ListView1" runat="server">
             <LayoutTemplate>
                            <div id="itemPlaceholderContainer" runat="server">
                                <div id="itemPlaceholder" runat="server">
                                </div>
                               
                            </div>
                        </LayoutTemplate>
            <ItemTemplate>
                <div style="width:100px;height:100px;"><img src="<%# Eval("Art_image")%>"  width="90" height="70"  />
                </div>
                <div style="text-align:center;">
                    <p><%#Eval("Art_title") %></p>
                </div>
            </ItemTemplate>
        </asp:ListView>
       <asp:DataPager runat="server" PagedControlID="ListView1" PageSize="2" ID="DDPager">
                        <Fields>
                            <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                            <asp:NumericPagerField ButtonCount="2" />
                            <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                        </Fields>
                    </asp:DataPager>
       
    </form>
</body>
</html>
