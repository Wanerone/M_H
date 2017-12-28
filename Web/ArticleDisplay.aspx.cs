using BLL;
using Models;
using System;
using System.Data;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ArticleDisplay : System.Web.UI.Page
    {
        public string ArtEmail;
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                Session["Email"] = "12@qq.com";
                ViewState["Art_id"] = 17;//  Convert.ToInt32(Request.QueryString["id"]);
                ArtEmail = ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email
                Bing();
                Bind2();
                BindList2();
                BindList3();
                //ArtEmail = ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email

                if (ArtStaticManager.addRead((int)ViewState["Art_id"]) == 1)//如果更新阅读次数成功
                {
                    BindReadCount();
                }
                if (ArtStaticManager.GetState((int) ViewState["Art_id"]) == 0)
                {
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                }
                else
                {
                    ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                }
                Label5.Text =" 收藏";
                Label6.Text = "评论数";
             
            }
           // Label9.Text= ArtStaticManager.Getcol(17).ToString();
           // ArtEmail = ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email
          //  Bind2();
            RepeaterBind1();
           // BindList2();
           // BindList3();
            num = ArtStaticManager.Getcol(17);
            Label10.Text = ArtStaticManager.Getcol(17).ToString();
        }

        //用户头像
        protected void Bind2()
        {
            DataTable dt = UserInManager.SelectID("12@qq.com");
            if (dt != null && dt.Rows.Count == 1)
            {
                Image2.ImageUrl = ResolveUrl(dt.Rows[0][2].ToString());
                
            }
        }
        //文章信息
        protected void Bing()
        {
            DataTable dt = ArticleManager.SelectID((int)ViewState["Art_id"]);
            if (dt != null && dt.Rows.Count == 1)
            {
                Image1.ImageUrl = ResolveUrl(dt.Rows[0][4].ToString());
                Label1.Text= dt.Rows[0][2].ToString();
                Label2.Text = dt.Rows[0][6].ToString();
                Label3.Text= string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][5]);                                                                                       
                //TextBox1.Text = dt.Rows[0][3].ToString();
                Label7.Text= dt.Rows[0][3].ToString();
            }
        }
        //文章作者信息
        private void BindList2()
        {
            /*  if (Session["Email"] != null)
              {
                  DataTable dt = UserInManager.SelectID(Session["Email"].ToString());
                  if (dt != null || dt.Rows.Count != 0)
                  {
                      ListView1.DataSource = dt;
                      ListView1.DataBind();
                  }
              }*/
            DataTable dt = UserInManager.SelectID(ArtEmail);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
       // 文章作者其他文章
        private void BindList3()
        {
            /*  if (Session["Email"] != null)
              {
                  DataTable dt = UserInManager.SelectID(Session["Email"].ToString());
                  if (dt != null || dt.Rows.Count != 0)
                  {
                      ListView1.DataSource = dt;
                      ListView1.DataBind();
                  }
              }*/
            DataTable dt = ArticleManager.SelectAll(ArtEmail);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
        //绑定阅读信息
        protected void BindReadCount()
        {
            DataTable dt = ArtStaticManager.SelectID((int)ViewState["Art_id"]);//根据文章ID找到文章的统计信息
            if (dt != null && dt.Rows.Count == 1)
            {
                Label4.Text = dt.Rows[0][1].ToString() + " 阅读";
            }
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
                    CS.Art_id = (int) ViewState["Art_id"];
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
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript","alert('对不起，请先登录！');", true);
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
        protected void ListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListView rpt = e.Item.FindControl("ListView2") as ListView;//找到里层的ListView;
                int id = Convert.ToInt32(((Label)e.Item.FindControl("Label11")).Text);
                DataTable sdr = ArticleReplyManager.SelectID(id);
                if (rpt != null)
                {
                    rpt.DataSource = sdr;
                    rpt.DataBind();
                }
            }
        }
        //收藏
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
            {
                if (ArtStaticManager.RedColl((int)ViewState["Art_id"]) == 1&&ArtStaticManager.UpdateFalse((int)ViewState["Art_id"])==1)
                {
                    num = num - 1;
                    Label10.Text = num.ToString();
                }
                ImageButton1.ImageUrl = "Tubiao/收藏.png";
            }
            else
            {
                ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                if (ArtStaticManager.addColl((int)ViewState["Art_id"]) == 1 && ArtStaticManager.UpdateTrue((int)ViewState["Art_id"]) == 1)
                {
                    num = num + 1;
                    Label10.Text = num.ToString();
                }
            }
        }
    }
}