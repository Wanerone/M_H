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
    public partial class FanjuJuchangMore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BindListView1();
            BindList2();
        }
        protected void BindListView1()
        {
            DataTable dt = AnimeManager.SelectJuchangAll();
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void BindList2()
        {
            DataTable dt = AnimeManager.SelectTop(9);
            if (dt != null || dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
    }
}