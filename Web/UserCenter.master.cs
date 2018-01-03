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
    public partial class UserCenter : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Name"] != null)
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
            }
            BindList1();
        }
        private void BindList1()
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
           DataTable dt = UserInManager.SelectID("222@qq.com");
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
    }
}