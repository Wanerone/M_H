<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Web.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="js/jquery.min.js"></script>
    <style>
        #praise {
            display: block;
            width: 40px;
            height: 40px;
            margin: 0 auto;
        }
        .praise {
            width: 40px;
            height: 40px;
            margin: 50px auto;
            cursor: pointer;
            font-size: 12px;
            text-align: center;
            position: relative;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="praise">
            <span id="praise"><img src="Tubiao/喜欢.png" id="praise-img" /></span>
            <span id="praise-txt" class="">1455</span>
        </div>
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="Tubiao/收藏.png"  />
            <asp:Label ID="Label1" runat="server" ></asp:Label>
        </div>
    </div>
        <script>
            /* @author:Romey
	 * 动态点赞
	 * 此效果包含css3，部分浏览器不兼容（如：IE10以下的版本）
	*/
            $(function(){
                $("#praise").click(function(){
                    var praise_img = $("#praise-img");
                    var text_box = $("#add-num");
                    var praise_txt = $("#praise-txt");
                    var num=parseInt(praise_txt.text());
                    if (praise_img.attr("src") == ("Tubiao/喜欢1.png")) {
                        $(this).html("<img src='Tubiao/喜欢.png' id='praise-img' class='animation' />");
                        praise_txt.removeClass("hover");
                        text_box.show().html("<em class='add-animation'>-1</em>");
                        $(".add-animation").removeClass("hover");
                        num -=1;
                        praise_txt.text(num)
                    }else{
                        $(this).html("<img src='Tubiao/喜欢1.png' id='praise-img' class='animation' />");
                        praise_txt.addClass("hover");
                        text_box.show().html("<em class='add-animation'>+1</em>");
                        $(".add-animation").addClass("hover");
                        num +=1;
                        praise_txt.text(num);
                    }
                });
            })
        </script>
    </form>
</body>
</html>
