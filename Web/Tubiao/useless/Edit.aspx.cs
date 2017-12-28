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
    public partial class Edit : System.Web.UI.Page
    {
        private UserIn user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["UserID"] != null)
                {
                    lblTitle.Text = "修改账号";
                    int id = int.Parse(Request.QueryString["UserID"]);
                    user= UserManger.Select(id);
                    ViewState["object"] = user;
                    tbMajorId.Text = user.UserID;
                    tbMajorName.Text = user.Password;
                }
                else
                {
                    lblTitle.Text = "增加账号";
                }
            }
        }

        protected void lbtnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (ViewState["object"] == null)
                {
                    user = new UserIn();
                }
                else
                {
                    user = (UserIn)ViewState["object"];
                }
                user.UserID = tbMajorId.Text.Trim();
                user.Password = tbMajorName.Text.Trim();
                try
                {
                    if (ViewState["object"] == null)
                    {
                       UserIn newMajor = UserManger.Add(user);
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "message", "<script>alert('添加成功！');</script>");
                    }
                    else
                    {
                        UserManger.Modify(user);
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "message", "<script>alert('修改成功！');</script>");
                    }

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message.ToString());
                }

            }

        }
    }
}