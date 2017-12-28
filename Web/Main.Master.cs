using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.NewFolder1
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BindList();
            BindList2();
        }
        private void BindList()
        {
            DataTable dt = ArticleManager.SelectTop(8);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void BindList2()
        {
            DataTable dt = ArticleManager.SelectTop(7);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
    }
}