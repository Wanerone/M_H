using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["Name"] != null && Session["Email"] != null)
                {
                    HyperLink2.Text = Session["Name"].ToString();
                    HyperLink2.NavigateUrl = "GeRenZhuYe.aspx";
                    HyperLink1.Visible = true;
                    HyperLink1.Text = "退出";
                    HyperLink1.NavigateUrl = "~/WebT.aspx";
                   
                }
                else
                {
                    HyperLink2.NavigateUrl = "Login.aspx";
                }
                if (Session["key"] != null)
                {
                    Label1.Text = VideoManager.CountLike(Session["key"].ToString()).ToString();
                    BindListView1();
                }
                else
                {
                    Label1.Text = "0";
                }
            }
            
            BindList2();
        }
        protected void BindListView1()
        {
            DataTable dt = VideoManager.SelectLike(Session["key"].ToString());
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void BindList2()
        {
            DataTable dt = VideoManager.SelectTop(9);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
    }
}