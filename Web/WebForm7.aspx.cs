using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected string emaill;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Email"] = "222@qq.com";
                ViewState["Art_id"] = 17;
                emaill = ArticleManager.GetEmail((int)ViewState["Art_id"]);//根据文章Id找到作者email
            }
            Bind2();
            RepeaterBind1();
        }

        protected void Bind2()
        {
            DataTable dt = UserInManager.SelectID("222@qq.com");
            if (dt != null && dt.Rows.Count == 1)
            {
                Image2.ImageUrl = ResolveUrl(dt.Rows[0][2].ToString());

            }
        }



        protected void Button3_Click(object sender, EventArgs e)
        {

            Response.Redirect("Login.aspx");

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel pl = (bt.Parent.FindControl("Panel1") as Panel);
            pl.Visible = !pl.Visible;

        }
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
        protected void button4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            //  try
            //   {
            Models.ArticleReply RS = new Models.ArticleReply();
            RS.ArticleComment_id = Int32.Parse((bt.Parent.FindControl("HiddenField1") as HiddenField).Value);
            RS.ArticleReply_id = ArticleReplyManager.CountReply() + 1;
            RS.ReplyContent = (bt.Parent.FindControl("TextBox2") as TextBox).Text.Trim(); ;
            RS.email = " 222@qq.com";
            RS.ReplyTime = DateTime.Now;
            if (ArticleReplyManager.addreply_art(RS) == 1)
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
                rpt.DataSource = sdr;
                rpt.DataBind();
            }
        }
    }
}