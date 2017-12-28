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
            if (!IsPostBack)
            {
                int vid = Convert.ToInt32(Request.QueryString["id"]);
                vid = 1;
                ViewState["vid"] = vid;
            }
            BindPlayVideo();

        }


        private void BindPlayVideo()
        {
            int vid = Convert.ToInt32(ViewState["vid"]);
            vid = 1;
            DataTable dt = VideoManager.selectKey(vid);
            if (dt != null && dt.Rows.Count == 1)
            {
                txtTitle.Text = dt.Rows[0][3].ToString();
               // txtCreateTime.Text = string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][2]);

                VDHF.Value = dt.Rows[0][2].ToString().Replace("~", "..");

             //   videoDLImgBtn.CommandArgument = dt.Rows[0][3].ToString();
               // txtClickNum.Text = (Convert.ToInt32(dt.Rows[0][4]) + BLL.VideoManager.updateClickNum(vid)).ToString();
              //  txtDownLoadNum.Text = dt.Rows[0][5].ToString();
            }
        }
    }
}