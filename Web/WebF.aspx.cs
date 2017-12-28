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
        }
    }
}