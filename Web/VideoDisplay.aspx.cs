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
        public string ArtEmail;
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Session["Email"] = "12@qq.com";
                ViewState["Vid_id"] = 1;//  Convert.ToInt32(Request.QueryString["id"]);
                ArtEmail = VideoManager.GetEmail((int)ViewState["Vid_id"]);//根据文章Id找到作者email
                Bing();
                Bind2();
                BindList2();
                if (VideoStaticManager.addRead((int)ViewState["Vid_id"]) == 1)//如果更新阅读次数成功
                {
                    BindReadCount();
                }
                Label5.Text = " 收藏";
                Label6.Text = "评论数";

            }

        }

        //用户头像
        protected void Bind2()
        {
           
        }
        //文章信息
        protected void Bing()
        {
            DataTable dt = VideoManager.selectKey((int)ViewState["Vid_id"]);
            if (dt != null && dt.Rows.Count == 1)
            {
                Label1.Text = dt.Rows[0][3].ToString();
                Label2.Text = dt.Rows[0][6].ToString();
                Label3.Text = string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][7]);
                ListView1.DataSource = dt;
                ListView1.DataBind();
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
            DataTable dt = VideoManager.SelectAll(ArtEmail);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
        protected void BindReadCount()
        {
            DataTable dt = VideoStaticManager.SelectID((int)ViewState["Vid_id"]);//根据文章ID找到文章的统计信息
            if (dt != null && dt.Rows.Count == 1)
            {
                Label4.Text = dt.Rows[0][1].ToString() + " 阅读";
            }
        }

    }
}