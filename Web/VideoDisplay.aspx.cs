using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class VideoDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Vid_id"] = Convert.ToInt32(Request.QueryString["id"]);
                Session["VideoEmail"] = VideoManager.GetEmail((int)ViewState["Vid_id"]);//根据视频Id找到作者email
                if (Session["Name"] != null && Session["Email"] != null)
                {
                    HyperLink2.Text = Session["Name"].ToString();
                    HyperLink2.NavigateUrl = "GeRenZhuYe.aspx";
                    HyperLink1.Visible = true;
                    HyperLink1.Text = "退出";
                    HyperLink1.NavigateUrl = "~/WebT.aspx";
                    if (FriendManager.Getid(Session["Email"].ToString(), Session["VideoEmail"].ToString()) != null)
                    {
                        ImageButton2.ImageUrl = "Tubiao/已关注.png";
                    }
                    else
                    {
                        ImageButton2.ImageUrl = "Tubiao/关注1.png";
                    }
                    if (VideoCollectionManager.GetState(Session["Email"].ToString(), (int)ViewState["Vid_id"]) != null)
                    {
                        if ((VideoCollectionManager.GetState(Session["Email"].ToString(), (int)ViewState["Vid_id"])).Equals("F"))
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
                    ImageButton2.ImageUrl = "Tubiao/关注1.png";
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                    HyperLink2.NavigateUrl = "Login.aspx";
                }
                Bing();
                Bind2();
                BindList2();
                BindList3();
                if (VideoStaticManager.addRead((int)ViewState["Vid_id"]) == 1)//如果更新阅读次数成功
                {
                    BindReadCount();
                }
                Label5.Text = VideoStaticManager.Getcol((int)ViewState["Vid_id"]).ToString() + "收藏";
                Label6.Text = VideoCommentManager.CountComment((int)ViewState["Vid_id"]).ToString() + "条评论";
                Label8.Text = VideoCommentManager.CountComment((int)ViewState["Vid_id"]).ToString();
                Label7.Text = VideoManager.countID(Session["VideoEmail"].ToString()).ToString();
                Label9.Text = FriendManager.count(Session["VideoEmail"].ToString()).ToString();
            }
            RepeaterBind1();
            Label10.Text = VideoStaticManager.Getcol((int)ViewState["Vid_id"]).ToString();
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
        //视频信息
        protected void Bing()
        {
            DataTable dt = VideoManager.selectKey((int)ViewState["Vid_id"]);
            if (dt != null && dt.Rows.Count == 1)
            {
                Label1.Text = dt.Rows[0][3].ToString();
                Label2.Text = dt.Rows[0][6].ToString();
                Label3.Text = string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][7]);
                ListView6.DataSource = dt;
                ListView6.DataBind();
            }
        }
        //视频作者信息
        private void BindList2()
        {
           
            DataTable dt = UserInManager.SelectID(Session["VideoEmail"].ToString());
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        // 文章作者其他文章
        private void BindList3()
        {
            
            DataTable dt = VideoManager.SelectAll(Session["VideoEmail"].ToString());
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
        protected void BindReadCount()
        {
            DataTable dt = VideoStaticManager.SelectID((int)ViewState["Vid_id"]);//根据视频ID找到视频的统计信息
            if (dt != null && dt.Rows.Count == 1)
            {
                Label4.Text = dt.Rows[0][1].ToString() + " 阅读";
            }
        }
        //评论按钮
        protected void Button3_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (Session["Name"] != null && Session["Email"] != null)
            {
                try
                {
                    VideoComment CS = new VideoComment();
                    CS.Vid_id = (int)ViewState["Vid_id"];
                    CS.email = Session["Email"].ToString();
                    CS.ComTime = DateTime.Now;
                    CS.ComContent = TextBox1.Text;
                    if (VideoCommentManager.addcomment_video(CS) == 1)
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
            int nid = (int)ViewState["Vid_id"];
            DataTable dt = VideoCommentManager.SelectID(nid);
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
            VideoReply rs = new VideoReply();
            HiddenField hf = bt.Parent.FindControl("HiddenField1") as HiddenField;
            rs.com_id = Int16.Parse(hf.Value);
            rs.ReplyContent = (bt.Parent.FindControl("TextBox2") as TextBox)?.Text.Trim();
            rs.email = Session["Email"].ToString();
            rs.ReplyTime = DateTime.Now;
            if (VideoReplyManager.addVideoReply(rs) == 1)
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
                DataTable sdr = VideoReplyManager.SelectID(id);
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
            if (Session["Name"] != null && Session["Email"] != null)
            {
                if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
                {
                    if (VideoStaticManager.RedColl((int)ViewState["Vid_id"]) == 1 && VideoCollectionManager.UpdateFalse(Session["Email"].ToString(), (int)ViewState["Vid_id"]) == 1)
                    {
                        Label10.Text = (Convert.ToInt32(Label10.Text) - 1).ToString();
                    }
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                }
                else
                {
                    if (VideoCollectionManager.GetState(Session["Email"].ToString(), (int)ViewState["Vid_id"]) == null)
                    {
                        VideoCollection art = new VideoCollection();
                        art.email = Session["Email"].ToString();
                        art.Vid_id = (int)ViewState["Vid_id"];
                        art.colState = "N";
                        if (VideoCollectionManager.add(art) == 1)
                        {
                            ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                            if (VideoStaticManager.addColl((int)ViewState["Vid_id"]) == 1)
                            {
                                Label10.Text = (Convert.ToInt32(Label10.Text) + 1).ToString();
                            }
                        }
                    }
                    else
                    {
                        ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                        if (VideoStaticManager.addColl((int)ViewState["Vid_id"]) == 1 && VideoCollectionManager.UpdateTrue(Session["Email"].ToString(), (int)ViewState["Vid_id"]) == 1)
                        {
                            Label10.Text = (Convert.ToInt32(Label10.Text) + 1).ToString();
                        }
                    }

                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('请登录！');", true);
            }
        }


        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Name"] != null && Session["Email"] != null)
            {
                if (ImageButton2.ImageUrl == "Tubiao/关注1.png")
                {
                    Friend f = new Friend();
                    // f.friend_id = FriendManager.count() + 1;
                    f.UserA = Session["Email"].ToString();
                    f.UserB = Session["VideoEmail"].ToString();
                    if (FriendManager.addFriend(f) == 1)
                    {
                        ImageButton2.ImageUrl = "Tubiao/已关注.png";
                    }
                }
                else
                {
                    if (FriendManager.deleteFriend(Session["Email"].ToString(), Session["VideoEmail"].ToString()) == 1)
                    {
                        ImageButton2.ImageUrl = "Tubiao/关注1.png";
                    }
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel2, this.GetType(), "updateScript", "alert('请登录！');", true);
            }

        }

    }
}