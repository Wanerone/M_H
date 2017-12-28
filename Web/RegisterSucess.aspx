<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegister.Master" AutoEventWireup="true" CodeBehind="RegisterSucess.aspx.cs" Inherits="Web.RegisterSucess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><div><img src="Image/小埋.jpg" /><h1>注册成功！</h1><p style="text-indent: 2em; margin-top: 30px;">
系统将在 <span id="time">5</span> 秒钟后自动跳转至首页，如果未能跳转，<a href="WebF.aspx" title="点击访问">请点击</a>。</p>
<script type="text/javascript">  
    delayURL();    
    function delayURL() { 
        var delay = document.getElementById("time").innerHTML;
 var t = setTimeout("delayURL()", 1000);
        if (delay > 0) {
            delay--;
            document.getElementById("time").innerHTML = delay;
        } else {
     clearTimeout(t); 
     window.location.href = "WebF.aspx";
        }        
    } 
</script></div></center>
    <center><div><article>您现在等级为0，可以进行收藏视频等常规操作，随着等级提升您拥有的功能将逐步增加。</article></div></center>
    <center><div><a href="Register.aspx">24小时内邮箱未激活账号将删除，你可以尝试重新注册</a></div></center>
</asp:Content>
