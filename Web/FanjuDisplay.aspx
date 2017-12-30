<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="FanjuDisplay.aspx.cs" Inherits="Web.FanjuDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
    </style>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="col-lg-8">
            <div class="display">
                <div class="Fanjuimage">
                    <asp:Image ID="Image1" runat="server" CssClass="img-rounded" />
                </div>
                <div class="FanjuInfo">
                    <div style="color: darkgoldenrod; font-size: x-large;"> <asp:Label ID="Label1" runat="server"></asp:Label></div>
                    <div class="praise">
                        <span id="praise"> <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="Tubiao/收藏.png" width="40" height="40"  /></span>
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
                   <div class="L_link"><a>哔哩哔哩</a></div>
                    <div class="L_link"><a>优酷</a></div>
                    <div class="L_link"><a>嘀哩嘀哩</a></div>
                </div>
    </div>
        </ContentTemplate>
        
    </asp:UpdatePanel>
    
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
                   <div class="ziti ziti2" style="padding: 6px; text-align:left;"> <a style="font-size:20px;" > <%#Eval("anime_Name") %></a>
                      </div>
                            </td>
                    </ItemTemplate>
                        </asp:ListView>
                    </div>
            </div>
    </div>
</asp:Content>
