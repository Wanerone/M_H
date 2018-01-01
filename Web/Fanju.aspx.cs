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
    public partial class Fanju : System.Web.UI.Page
    {
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
            }

            BindList1();
            BindList2();
            BindList3();
            BindList4();
            BindList5();
        }
        //绑定最近更新
        private void BindList1()
        {
            DataTable dt = AnimeManager.SelectTop(6);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        //绑定排行
        private void BindList2()
        {
            DataTable dt = AnimeManager.SelectTop(9);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        //绑定国产
        private void BindList3()
        {
            DataTable dt = AnimeManager.SelectTopGuochan(6);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }

        //绑定日漫
        private void BindList4()
        {
            DataTable dt = AnimeManager.SelectTopRiman(6);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView4.DataSource = dt;
                ListView4.DataBind();
            }
        }
        //绑定剧场版
        private void BindList5()
        {
            DataTable dt = AnimeManager.SelectTopJuchang(6);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView5.DataSource = dt;
                ListView5.DataBind();
            }
        }
    }
}