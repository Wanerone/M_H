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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }


        private void Bind()
        {
            if (Session["key"] != null)
            {
                DataTable dt = ArticleManager.SelectLike(Session["key"].ToString());
                if (dt != null || dt.Rows.Count != 0)
                {
                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                }
            }
        }
    }
}