using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;

namespace Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Email"] = "12@qq.com";
                ViewState["Art_id"] = 17;
            }
            RepeaterBind1();
        }

        //评论按钮
        protected void Button3_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (Session["Email"] != null)
            {
                try
                {
                    ArticleComment CS = new ArticleComment();
                    CS.ArticleComment_id = ArticleCommentManager.CountComment() + 1;
                    //Session["pinlunid"] = CS.ArticleComment_id;
                    CS.Art_id = (int)ViewState["Art_id"];
                    //email为用户的email  CS.email=Session["Email"].ToString();
                    CS.email = Session["Email"].ToString();
                    CS.ComTime = DateTime.Now;
                    CS.ComContent = TextBox1.Text;
                    if (ArticleCommentManager.addComment_AC(CS) == 1)
                    {
                        TextBox1.Text = "";
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('评论成功！');", true);
                        RepeaterBind1();
                        // (Repeater1.FindControl("Lable19") as Label).Text = (ArticleCommentManager.CountComment((int)ViewState["Art_id"])).ToString();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('评论失败！');", true);
                    }
                }

                catch (Exception ex)
                {
                    Response.Write("错误原因：" + ex.Message);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('对不起，请先登录！');", true);
            }

        }
        //弹出回复框
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Control re = bt.Parent;
            Panel pl = (bt.Parent.FindControl("Panel1") as Panel);
            pl.Visible = !pl.Visible;
            // RepeaterBind1();
        }
        //绑定显示评论
        private void RepeaterBind1()
        {
            int nid = (int)ViewState["Art_id"];
            DataTable dt = ArticleCommentManager.SelectID(nid);
            if (dt != null && dt.Rows.Count != 0)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }
        //回复按钮
        protected void Button4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            //  try
            //   {
            ArticleReply rs = new ArticleReply();
            HiddenField hf = bt.Parent.FindControl("HiddenField1") as HiddenField;
            rs.ArticleComment_id = Int16.Parse(hf.Value);
            rs.ArticleReply_id = ArticleReplyManager.CountReply() + 1;
            rs.ReplyContent = (bt.Parent.FindControl("TextBox2") as TextBox)?.Text.Trim();
            rs.email = Session["Email"].ToString();
            rs.ReplyTime = DateTime.Now;
            if (ArticleReplyManager.addreply_art(rs) == 1)
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复成功！');", true);
                RepeaterBind1();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复失败！');", true);

            }

            //   }
            //   catch (Exception ex)
            //  {
            //      Response.Write("错误原因：" + ex.Message);
            //   }

        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rpt = e.Item.FindControl("Repeater2") as Repeater;//找到里层的repeate;
                int id = Convert.ToInt32(((Label)e.Item.FindControl("Label11")).Text);
                DataTable sdr = ArticleReplyManager.SelectID(id);
                if (rpt != null)
                {
                    rpt.DataSource = sdr;
                    rpt.DataBind();
                }
            }
        }

    }
}