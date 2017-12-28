<%@ Page Title="" Language="C#" MasterPageFile="~/UserCenter.master" AutoEventWireup="true" CodeBehind="InfoSet.aspx.cs" Inherits="Web.InfoSet" %>
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
        .baocun{
            margin:50px 350px;
        }
        #content {
        position :absolute;
        margin:0 auto;
        top:150px;
        width:100%;
        height:50px;
        text-align:center;
        font-family:"微软雅黑";
        font-size:20px;
        }
        #title {
        text-align:center;
        top:50px;
        font-family:"微软雅黑";
        font-size:48px;
        }
        .styled {
        border-radius:5px;
        width:158px;
        height:25px;
        padding:0 24px 0 8px;
        color:#fff;
        background-color:#3d69f7;
        font:14px "微软雅黑";
        }
    </style>
    
    <div class="tou"><span>信息设置</span></div>
    <div class="xia">
        <table class="table table-bordered">
            <tr>
                <td>邮箱</td>
                <td>
                    <asp:Label ID="Label1" runat="server" ForeColor="#476269"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>昵称</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="150" Height="30" MaxLength="8" TextMode="SingleLine" BorderColor="#616161" BorderWidth="1"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" ForeColor="#CC0000"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>性别</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="男" >&nbsp;</asp:ListItem>
                        <asp:ListItem Text="女">&nbsp;</asp:ListItem>
                        <asp:ListItem Text="保密">&nbsp;</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>出生日期</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" BorderColor="#616161" BorderWidth="1"></asp:TextBox>&nbsp;<asp:ImageButton
                ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Image/calendar.gif"
                OnClick="ImageButton1_Click" Width="27px" />         
                <asp:Calendar ID="Calendar1" runat="server" 
                OnSelectionChanged="Calendar1_SelectionChanged" Visible="False" 
            BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" 
            DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
            ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
            </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>住址</td>
                <td>
	                    <asp:ScriptManager ID="ProvinceContect" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="bind_Province" CssClass="styled" 
                                        runat="server" AutoPostBack="True" onselectedindexchanged="bind_Province_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="bind_City" CssClass="styled" 
                                        runat="server" AutoPostBack="True" onselectedindexchanged="bind_City_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="bind_Borough" CssClass="styled" runat="server">
                                    </asp:DropDownList>
                                </ContentTemplate>
        </asp:UpdatePanel>              
                </td>
            </tr>
            <tr>
                <td>个性签名</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="500" Height="150" TextMode="MultiLine" BorderColor="#616161"></asp:TextBox>
                    </td>
            </tr>
        </table>
    </div>
    <div  class="baocun">
        <asp:Button ID="Button1" runat="server" Text="保存" CssClass="btn-lg" ForeColor="#00A1D6" OnClick="Button1_Click" /></div>
</asp:Content>
