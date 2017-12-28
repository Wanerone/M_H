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

    public partial class UserBrower : System.Web.UI.Page
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
                lblTitle.Text = "总共找到了个 " + list.Count + " 账号";
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
            else
            {
                lblTitle.Text = "没有找到任何专业！";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "MyDelete")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                string name = UserManger.Select(id).Password;
                if (UserManger.Delete(id))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "DeleteOk", "alert('用户【" + name + "】删除成功！');", true);
                    FillData();
                }
            }
        }

        protected void lbtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}