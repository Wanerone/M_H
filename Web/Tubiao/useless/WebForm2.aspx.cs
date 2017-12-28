using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillData();
            }
        }
        private void FillData()
        {
            List<UserIn> list = UserManger.SelectAll();
            if (list != null)
            {
                Label1.Text = "总共找到了个 " + list.Count + " 用户。";
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
            else
            {
                Label1.Text = "没有找到任何用户！";
            }
        }
    }
}