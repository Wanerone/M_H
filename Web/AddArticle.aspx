<%@ Page Title="" Language="C#" MasterPageFile="~/Gaojian.master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="Web.AddArticle" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>  

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder11" runat="server">
    <div class="table-responsive" style="padding-top:25px;">
  <table class="table">
      <tbody>
      <tr>
        <td colspan="3">
            <asp:TextBox ID="TextBox1" runat="server" Height="40px" MaxLength="30" Width="100%" BorderStyle="None" BorderWidth="0px" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="X-Large"  Text="标题(不多于30个字符)" onclick="Clear();" onblur="Get();"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="标题不为空" ControlToValidate="TextBox1" Display="Dynamic"  ></asp:RequiredFieldValidator></td></tr>
      <tr>
        <td colspan="3">
            <CKEditor:CKEditorControl ID="txtContent" runat="server" BasePath="ckeditor/" DefaultLanguage="zh-cn" Width="880" Height="600">
                </CKEditor:CKEditorControl>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="内容不为空" ControlToValidate="txtContent" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
      <tr>
        <td><h4>封面</h4></td>
        <td> <asp:FileUpload ID="FileUpload1" runat="server" /></td></tr>
      <tr>
        <td><h4>选择分区</h4></td>
         <td colspan="2">
                <div class="btn-group btn-group-lg">
	            <button id="bu1" type="button" class="btn btn-default">画漫</button>
                </div>
              <div class="btn-group btn-group-lg">
	            <button id="bu2" type="button" class="btn btn-default">番剧</button>
                </div>
              <div class="btn-group btn-group-lg">
	            <button id="bu3" type="button" class="btn btn-default">音乐</button>
                </div>
              <div class="btn-group btn-group-lg">
	            <button id="bu4" type="button" class="btn btn-default">游戏</button>
                </div>
              <div class="btn-group btn-group-lg">
	            <button id="bu5" type="button" class="btn btn-default">小说</button>
                  </div>
                   <div class="btn-group btn-group-lg">
	            <button id="bu6" type="button" class="btn btn-default">线下活动</button>
                </div>
             <br />
             <br />
            <a style="color:black;">你的选择:</a> <asp:Label ID="Label1" runat="server"  Font-Bold="True" ForeColor="blue" ></asp:Label>
             <asp:HiddenField ID="HiddenField1" runat="server" />
             <br />
             </td>
      </tr>
          <tr>
              <td></td>
              <td>
                  <asp:Button ID="Button2" runat="server" Text="发布" BackColor="#CC0000" CssClass="btn-warning" Height="33px" OnClick="Button2_Click" Width="92px" /></td>
          </tr>
    </tbody>
      </table>
      </div>
    <script>
        function Clear() {
            if (document.getElementById("<%=TextBox1.ClientID%>").value == "标题(不多于30个字符)") {
                document.getElementById("<%=TextBox1.ClientID%>").value = "";
            }
            
        }
        function Get() {
            if (document.getElementById("<%=TextBox1.ClientID%>").value == "") {
                document.getElementById("<%=TextBox1.ClientID%>").value = "标题(不多于30个字符)";
            }
            
        }
        $(document).ready(function () {
            $("#bu1").click(function () {
                $("#<%=Label1.ClientID%>").text("画漫");
                $("#<%=HiddenField1.ClientID%>").val("画漫");
               // $("#<%=Label1.ClientID%>").css("color":"blue");
            });
            $("#bu2").click(function () {
                $("#<%=Label1.ClientID%>").html("番剧");
                $("#<%=HiddenField1.ClientID%>").val("番剧");
            });
            $("#bu3").click(function () {
                $("#<%=Label1.ClientID%>").html(" 音乐");
                $("#<%=HiddenField1.ClientID%>").val("音乐");
            });
            $("#bu4").click(function () {
                $("#<%=Label1.ClientID%>").html("游戏");
                 $("#<%=HiddenField1.ClientID%>").val("游戏");
            });
            $("#bu5").click(function () {
                $("#<%=Label1.ClientID%>").html("小说");
                 $("#<%=HiddenField1.ClientID%>").val("小说");
            });
            $("#bu6").click(function () {
                $("#<%=Label1.ClientID%>").html(" 线下活动")
                 $("#<%=HiddenField1.ClientID%>").val("线下活动");
            });
        });
    </script>
</asp:Content>
