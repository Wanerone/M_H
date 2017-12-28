using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Video : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           Models.Video videos = new Models.Video();
            videos.Vid_title = VideoTitle.Text;
            videos.Vid_creattime = DateTime.Now;
            videos.Vid_id = 1;
            if (Session["Email"] != null)
            {
                videos.email = Session["Email"].ToString();
            }
            else videos.email = DBNull.Value.ToString();
            videos.Vid_jianjie = TextBox1.Text.Trim();
            videos.Vid_category = Label7.Text;
            try
            {

                if (FileVideo.HasFile)
                {
                    string filePath = FileVideo.PostedFile.FileName;
                    string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath(@"~\Video\") + fileName;
                    string relativepath = @"~\Video\" + fileName;
                    FileVideo.PostedFile.SaveAs(serverpath);
                    videos.Vid_url= relativepath;
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传视频！');</script>");
                    return;
                }
                if (FileScreen.HasFile)
                {

                    string filePathImg = FileScreen.PostedFile.FileName;
                    string fileNameImg = filePathImg.Substring(filePathImg.LastIndexOf("\\") + 1);
                    string serverpathImg = Server.MapPath(@"~\VideoImg\") + fileNameImg;
                    string relativepathImg = @"~\VideoImg\" + fileNameImg;
                    FileScreen.PostedFile.SaveAs(serverpathImg);
                    videos.Vid_img = relativepathImg;
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请添加截屏照片！');</script>");
                    return;
                }
            }
            catch
            { }
            //if (!string.IsNullOrEmpty(FileVideo.PostedFile.ContentLength))
            //{
            if (!string.IsNullOrEmpty(VideoTitle.Text))
            {
                if (VideoManager.addVideo(videos) == 1)
                {
                    VideoTitle.Text = "";
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请输入标题！');</script>");
            }
        }
    }
}