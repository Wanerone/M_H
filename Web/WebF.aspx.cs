using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Name"] != null&&Session["Email"]!=null)
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
        }
    }
}