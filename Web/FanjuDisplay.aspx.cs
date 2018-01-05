using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Web.Services;
using Models;

namespace Web
{
    public partial class FanjuDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["anime_ID"] = Convert.ToInt32(Request.QueryString["id"]);//获得动画ID
                if (Session["Name"] != null && Session["Email"] != null)
                {
                    HyperLink2.Text = Session["Name"].ToString();
                    HyperLink2.NavigateUrl = "GeRenZhuYe.aspx";
                    HyperLink1.Visible = true;
                    HyperLink1.Text = "退出";
                    HyperLink1.NavigateUrl = "~/WebT.aspx";
                    if (AnimeCollectionManager.GetState(Session["Email"].ToString(), (int)ViewState["anime_ID"]) != null)
                        {
                            if ((AnimeCollectionManager.GetState(Session["Email"].ToString(), (int)ViewState["anime_ID"])).Equals("F"))
                            {
                                ImageButton1.ImageUrl = "Tubiao/收藏.png";
                            }
                            else
                            {
                                ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                            }
                        }
                        else
                        {
                            ImageButton1.ImageUrl = "Tubiao/收藏.png";
                        }
                }
                else
                {
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                    HyperLink2.NavigateUrl = "Login.aspx";
                }
                Bind2();
                Bind();
                BindList5();
                Label3.Text = AnimeStaticManager.Getcol((int)ViewState["anime_ID"]).ToString();
            }
            RepeaterBind1();
        }

        //动漫信息
        protected void Bind()
        {
            DataTable dt = AnimeManager.SelectID((int)ViewState["anime_ID"]);
            if (dt != null && dt.Rows.Count == 1)
            {
                Image1.ImageUrl = ResolveUrl(dt.Rows[0][2].ToString());
                Label1.Text = dt.Rows[0][1].ToString();
                Label4.Text = dt.Rows[0][6].ToString();
                Label5.Text = dt.Rows[0][4].ToString();
                Label6.Text = dt.Rows[0][7].ToString();
                //TextBox1.Text = dt.Rows[0][3].ToString();
                Label7.Text = dt.Rows[0][5].ToString();
            }
        }
        //收藏
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Name"] != null && Session["Email"] != null)
            {
                if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
                {
                    if (AnimeStaticManager.RedColl((int)ViewState["anime_ID"]) == 1 && AnimeCollectionManager.UpdateFalse(Session["Email"].ToString(), (int)ViewState["anime_ID"]) == 1)
                    {
                        Label3.Text = (Convert.ToInt32(Label3.Text) - 1).ToString();
                    }
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                }
                else
                {
                    if (AnimeCollectionManager.GetState(Session["Email"].ToString(), (int)ViewState["anime_ID"]) == null)
                    {
                        AnimeCollection art = new AnimeCollection();
                        art.email = Session["Email"].ToString();
                        art.anime_ID = (int)ViewState["anime_ID"];
                        art.colState = "N";
                        if (AnimeCollectionManager.add(art) == 1)
                        {
                            ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                            if (AnimeStaticManager.addColl((int)ViewState["anime_ID"]) == 1)
                            {
                                Label3.Text = (Convert.ToInt32(Label3.Text) + 1).ToString();
                            }
                        }
                    }
                    else
                    {
                        ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                        if (AnimeStaticManager.addColl((int)ViewState["anime_ID"]) == 1 && AnimeCollectionManager.UpdateTrue(Session["Email"].ToString(), (int)ViewState["anime_ID"]) == 1)
                        {
                            Label3.Text = (Convert.ToInt32(Label3.Text) + 1).ToString();
                        }
                    }

                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel2, this.GetType(), "updateScript", "alert('请登录！');", true);
            }
        }
        //动漫排行信息
        private void BindList5()
        {
            DataTable dt = AnimeManager.SelectTop(7);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView5.DataSource = dt;
                ListView5.DataBind();
            }
        }
        //用户头像
        protected void Bind2()
        {
            if (Session["Email"] != null)
            {
                DataTable dt = UserInManager.SelectID(Session["Email"].ToString());
                if (dt != null && dt.Rows.Count == 1)
                {
                    Image2.ImageUrl = ResolveUrl(dt.Rows[0][2].ToString());

                }
            }

        }
        //评论按钮
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Email"] != null)
            {
                try
                {
                    AnimeComment CS = new AnimeComment();
                    CS.anime_ID = (int)ViewState["anime_ID"];
                    //email为用户的email  CS.email=Session["Email"].ToString();
                    CS.email = Session["Email"].ToString();
                    CS.time = DateTime.Now;
                    CS.comment = TextBox1.Text;
                    if (AnimeCommentManager.addComment_AC(CS) == 1)
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
            int nid = (int)ViewState["anime_ID"];
            DataTable dt = AnimeCommentManager.SelectID(nid);
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        //回复按钮
        protected void Button4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            //  try
            //   {
            AnimeReply rs = new AnimeReply();
            HiddenField hf = bt.Parent.FindControl("HiddenField1") as HiddenField;
            rs.com_id = Int16.Parse(hf.Value);
            rs.reply_content = (bt.Parent.FindControl("TextBox2") as TextBox)?.Text.Trim();
            rs.email = Session["Email"].ToString();
            rs.reply_time = DateTime.Now;
            if (AnimeReplyManager.addreply(rs) == 1)
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
        protected void ListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListView rpt = e.Item.FindControl("ListView2") as ListView;//找到里层的ListView;
                int id = Convert.ToInt32(((Label)e.Item.FindControl("Label11")).Text);
                DataTable sdr = AnimeReplyManager.SelectID(id);
                if (rpt != null)
                {
                    rpt.DataSource = sdr;
                    rpt.DataBind();
                }
            }
        }
    }
}