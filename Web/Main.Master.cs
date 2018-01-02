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

            BindList1();
            BindList2();
            BindList3();
            BindList4();
        }
        private void BindList1()
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
        private void BindList3()
        {
            DataTable dt = AnimeManager.SelectTop(8);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
        private void BindList4()
        {
            DataTable dt = AnimeStaticManager.Readtop(7);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView4.DataSource = dt;
                ListView4.DataBind();
            }
        }
    }
}