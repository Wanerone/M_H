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
        public string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ViewState["Art_id"] =  Convert.ToInt32(Request.QueryString["id"]);
                ArtEmail = ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email
                Session["ArtEmail"]= ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email
                if (Session["Name"] != null)
                {
                   HyperLink2.Text = Session["Name"].ToString();
                    HyperLink2.NavigateUrl= "GeRenZhuYe.aspx";
                    HyperLink1.Visible = true;
                    HyperLink1.Text = "退出";
                    HyperLink1.NavigateUrl = "~/WebT.aspx";
                    email = UsersManager.SelectEmail(Session["Name"].ToString());
                    Session["Eemail"]= UsersManager.SelectEmail(Session["Name"].ToString());
                    if (FriendManager.GetUserB(email)==ArtEmail)
                    {
                        ImageButton2.ImageUrl = "Tubiao/已关注.png";
                    }
                    else
                    {
                        ImageButton2.ImageUrl = "Tubiao/关注1.png";
                    }
                    if (ArtCollectionManager.GetState(Session["Eemail"].ToString(), (int)ViewState["Art_id"]) != null)
                    {
                        if ((ArtCollectionManager.GetState(Session["Eemail"].ToString(), (int)ViewState["Art_id"])).Equals("F"))
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
                //Session["Email"] = "12@qq.com";
                Bing();
                Bind2();
                BindList2();
                BindList3();
                //ArtEmail = ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email

                if (ArtStaticManager.addRead((int)ViewState["Art_id"]) == 1)//如果更新阅读次数成功
                {
                    BindReadCount();
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
            num = ArtStaticManager.Getcol((int)ViewState["Art_id"]);
            Label10.Text = ArtStaticManager.Getcol((int)ViewState["Art_id"]).ToString();
        }

        //用户头像
        protected void Bind2()
        {
            if (email != null)
            {
                DataTable dt = UserInManager.SelectID(email);
            if (dt != null && dt.Rows.Count == 1)
            {
                Image2.ImageUrl = ResolveUrl(dt.Rows[0][2].ToString());
                
            } }
           
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
            DataTable dt = UserInManager.SelectID(Session["ArtEmail"].ToString());
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
            
            if (Session["Name"] != null)
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
        //弹出回复框
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Control re = bt.Parent;
            Panel pl = (bt.Parent.Parent.FindControl("Panel1") as Panel);
            if (pl!=null)
            {
                pl.Visible = !pl.Visible;
            }
           
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
            if (Session["Name"] != null)
            {
                 if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
                    {
                        if (ArtStaticManager.RedColl((int)ViewState["Art_id"]) == 1&&ArtCollectionManager.UpdateFalse(Session["Eemail"].ToString(),(int)ViewState["Art_id"])==1)
                        {
                            num = num - 1;
                            Label10.Text = num.ToString();
                        }
                        ImageButton1.ImageUrl = "Tubiao/收藏.png";
                    }
                    else
                    {
                        if (ArtCollectionManager.GetState(Session["Eemail"].ToString(), (int)ViewState["Art_id"]) == null)
                        {
                            ArtCollection art = new ArtCollection();
                            art.email = Session["Eemail"].ToString();
                            art.Art_id = (int)ViewState["Art_id"];
                            art.colState = "N";
                            if (ArtCollectionManager.add(art)==1)
                            {
                                ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                                if (ArtStaticManager.addColl((int)ViewState["Art_id"]) == 1 )
                                {
                                    num = num + 1;
                                    Label10.Text = num.ToString();
                                }
                            }
                        }
                        else
                        {
                            ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                            if (ArtStaticManager.addColl((int)ViewState["Art_id"]) == 1 && ArtCollectionManager.UpdateTrue(Session["Eemail"].ToString(), (int)ViewState["Art_id"]) == 1)
                            {
                                num = num + 1;
                                Label10.Text = num.ToString();
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
            if (Session["Name"] != null)
            {
                 if (ImageButton2.ImageUrl == "Tubiao/关注1.png")
                    {
                        Friend f = new Friend();
                        f.friend_id = FriendManager.count() + 1;
                        f.UserA = Session["Eemail"].ToString();
                        f.UserB =Session["ArtEmail"].ToString();
                        if (FriendManager.addFriend(f) == 1)
                        {
                            ImageButton2.ImageUrl = "Tubiao/已关注.png";
                        }
                    }
                    else
                    {
                        if (FriendManager.deleteFriend(Session["Eemail"].ToString(), Session["ArtEmail"].ToString()) == 1)
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