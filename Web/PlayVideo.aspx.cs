using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class PlayVideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int vid = Convert.ToInt32(Request.QueryString["id"]);
                ViewState["vid"] = vid;
            }
            BindPlayVideo();
        }
        private void BindPlayVideo()
        {
            int vid = Convert.ToInt32(ViewState["vid"]);
            DataTable dt = VideoManager.selectKey(vid);
            if (dt != null && dt.Rows.Count == 1)
            {
                txtTitle.Text = dt.Rows[0][1].ToString();
                txtCreateTime.Text = string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][2]);

                VDHF.Value = dt.Rows[0][3].ToString().Replace("~", "..");

             //   videoDLImgBtn.CommandArgument = dt.Rows[0][3].ToString();
              //  txtClickNum.Text = (Convert.ToInt32(dt.Rows[0][4]) + BLL.VideoManager.updateClickNum(vid)).ToString();
               // txtDownLoadNum.Text = dt.Rows[0][5].ToString();
            }
        }


        protected void videoDLImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton dl = sender as ImageButton;
                string fileName = txtTitle.Text.Trim() + "." + GetFileFormat(dl.CommandArgument);
                string filePath = Server.MapPath(dl.CommandArgument);
                if (File.Exists(filePath))
                {
                    FileInfo fi = new FileInfo(filePath);
                    Response.Clear();
                    Response.ContentType = "application/octet-stream";
                    if (Request.UserAgent.ToLower().IndexOf("msie") > -1)
                    {
                        fileName = HttpUtility.UrlPathEncode(fileName);
                    }
                    if (Request.UserAgent.ToLower().IndexOf("firefox") > -1)
                    {

                        Response.AddHeader("Content-Disposition", "attachment;filename=\"" + fileName + "\"");
                    }
                    else
                    {
                        fileName = HttpUtility.UrlEncode(fileName);
                        Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
                    }

                    Response.AddHeader("Content-Length", fi.Length.ToString());
                  //  txtDownLoadNum.Text = (Convert.ToInt32(txtDownLoadNum.Text) + BLL.VideoManager.updateDownLoadNum(Convert.ToInt32(ViewState["vid"]))).ToString();


                    Response.WriteFile(filePath);

                    Response.Flush();
                    Response.End();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "update2", "alert('文件不存在！');", true);
                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "update2", "alert('下载失败！');", true);
            }

        }
        public static string GetFileFormat(string address)
        {
            return address.Split('.')[1];
        }
    }
}