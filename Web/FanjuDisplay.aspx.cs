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
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["anime_ID"] = Convert.ToInt32(Request.QueryString["id"]);//获得动画ID
                if (Session["Name"] != null)
                {
                    HyperLink2.Text = Session["Name"].ToString();
                    HyperLink2.NavigateUrl = "GeRenZhuYe.aspx";
                    HyperLink1.Visible = true;
                    HyperLink1.Text = "退出";
                    HyperLink1.NavigateUrl = "~/WebT.aspx";
                    Session["Eemail"] = UsersManager.SelectEmail(Session["Name"].ToString());
                    if (AnimeCollectionManager.GetState(Session["Eemail"].ToString(), (int)ViewState["anime_ID"]) != null)
                        {
                            if ((AnimeCollectionManager.GetState(Session["Eemail"].ToString(), (int)ViewState["anime_ID"])).Equals("F"))
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
               
                Bind();
                BindList2();
                num = AnimeStaticManager.Getcol((int)ViewState["anime_ID"]);
                Label3.Text = AnimeStaticManager.Getcol((int)ViewState["anime_ID"]).ToString();
            }
            
        }
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
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Name"] != null)
            {
                if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
                {
                    if (AnimeStaticManager.RedColl((int)ViewState["anime_ID"]) == 1 && AnimeCollectionManager.UpdateFalse(Session["Eemail"].ToString(), (int)ViewState["anime_ID"]) == 1)
                    {
                     //   num = num - 1;
                      //  Label3.Text = num.ToString();
                        Label3.Text = (Convert.ToInt32(Label3.Text) - 1).ToString();
                    }
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                }
                else
                {
                    if (AnimeCollectionManager.GetState(Session["Eemail"].ToString(), (int)ViewState["anime_ID"]) == null)
                    {
                        AnimeCollection art = new AnimeCollection();
                        art.email = Session["Eemail"].ToString();
                        art.anime_ID = (int)ViewState["anime_ID"];
                        art.colState = "N";
                        if (AnimeCollectionManager.add(art) == 1)
                        {
                            ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                            if (ArtStaticManager.addColl((int)ViewState["anime_ID"]) == 1)
                            {
                                Label3.Text = (Convert.ToInt32(Label3.Text) + 1).ToString();
                              //  Label3.Text = num.ToString();
                            }
                        }
                    }
                    else
                    {
                        ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                        if (AnimeStaticManager.addColl((int)ViewState["anime_ID"]) == 1 && AnimeCollectionManager.UpdateTrue(Session["Eemail"].ToString(), (int)ViewState["anime_ID"]) == 1)
                        {
                            Label3.Text = (Convert.ToInt32(Label3.Text) + 1).ToString();
                           // Label3.Text = num.ToString();
                        }
                    }

                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('请登录！');", true);
            }
        }
        private void BindList2()
        {
            DataTable dt = AnimeManager.SelectTop(7);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
    }
}