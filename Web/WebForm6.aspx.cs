using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            num = AnimeStaticManager.Getcol(17);
            Label1.Text = AnimeStaticManager.Getcol(17).ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            ArticleReply RS = new ArticleReply();
            RS.ArticleComment_id = 1;
            RS.ArticleReply_id = ArticleReplyManager.CountReply() + 1;
            RS.ReplyContent = "eee22222";
            RS.email = "222@qq.com";
            RS.ReplyTime = DateTime.Now;
            if (ArticleReplyManager.addreply_art(RS) == 1)
            {
                //ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复成功！');", true);
                // RepeaterBind1();
                ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('保存成功!')</script>");
            }
            else
            {
                // ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复失败！');", true);
                ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('保存成功!')</script>");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
            {
                if (AnimeStaticManager.RedColl(17) == 1)
                {
                    num = num - 1;
                    Label1.Text = num.ToString();
                }
                ImageButton1.ImageUrl = "Tubiao/收藏.png";
            }
            else
            {
                ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                if (AnimeStaticManager.addColl(17) == 1)
                {
                    num = num +1;
                    Label1.Text = num.ToString();
                }
            }
        }
    }
}