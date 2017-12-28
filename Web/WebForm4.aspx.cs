using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;
using System.Data;

namespace Web
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterBind1();
        }
        protected void pinglun_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (Session["userName"] != null)
            {
                try
                {
                    ArticleComment CS = new ArticleComment();
                    CS.ArticleComment_id = ArticleCommentManager.CountComment() + 1;
                    CS.email = Session["Email"].ToString();
                    CS.Art_id = (int)ViewState["Art_id"];
                    CS.ComContent = FCKeditor1.Text;
                    CS.ComTime = DateTime.Now;
                    if (Comment_ACManager.addComment_AC(CS) == 1)
                    {
                        FCKeditor1.Text = "";
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('评论成功！');", true);

                        ListView1();
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

        protected void BttLogin_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (Session["userName"] != null)
            {
                try
                {
                    UTravel.Models.Reply_AC RS = new UTravel.Models.Reply_AC();
                    RS.comment_ac_id = Int32.Parse((bt.Parent.FindControl("HiddenField1") as HiddenField).Value);
                    RS.content = (bt.Parent.FindControl("FCKeditor2") as TextBox).Text.Trim();
                    RS.users_id = int.Parse(Session["userid"].ToString());
                    RS.addtime = DateTime.Now;
                    if (Reply_ACManager.addreply_ac(RS) == 1)
                    {
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复成功！');", true);
                        ListView1();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复失败！');", true);

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


        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rpt = e.Item.FindControl("Repeater2") as Repeater;//找到里层的repeate;
                int id = Convert.ToInt32(((Label)e.Item.FindControl("Label3")).Text);
                DataTable sdr = Reply_ACManager.SelectID(id);
                rpt.DataSource = sdr;
                rpt.DataBind();
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel pl = (bt.Parent.FindControl("Panel1") as Panel);
            pl.Visible = !pl.Visible;

        }
    }

    }
    