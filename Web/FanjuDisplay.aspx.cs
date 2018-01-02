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

namespace Web
{
    public partial class FanjuDisplay : System.Web.UI.Page
    {
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Name"] != null)
                {
                    LinkButton1.Text = Session["Name"].ToString();
                    LinkButton1.PostBackUrl = "GeRenZhuYe.aspx";
                    LinkButton2.Text = "退出";
                }
                else
                {
                    LinkButton1.PostBackUrl = "Login.aspx";
                }
                ViewState["anime_ID"] = Convert.ToInt32(Request.QueryString["id"]);
                if (AnimeStaticManager.GetState((int)ViewState["anime_ID"]) == 0)
                {
                    ImageButton1.ImageUrl = "Tubiao/收藏.png";
                }
                else
                {
                    ImageButton1.ImageUrl = "Tubiao/收藏1.png";
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
            if (ImageButton1.ImageUrl == "Tubiao/收藏1.png")
            {
                if (AnimeStaticManager.RedColl((int)ViewState["anime_ID"]) == 1)
                {
                    num = num - 1;
                    Label3.Text = num.ToString();
                }
                ImageButton1.ImageUrl = "Tubiao/收藏.png";
            }
            else
            {
                ImageButton1.ImageUrl = "Tubiao/收藏1.png";
                if (AnimeStaticManager.addColl((int)ViewState["anime_ID"]) == 1)
                {
                    num = num + 1;
                    Label3.Text = num.ToString();
                }
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