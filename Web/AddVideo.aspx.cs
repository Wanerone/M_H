using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AddVideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Email"] = "12@qq.com";
        }

        public void AddVideoss()
        {
            Models.Video videos = new Models.Video();
            videos.Vid_title = TextBox1.Text;
            videos.Vid_creattime = DateTime.Now;
            videos.Vid_jianjie = TextBox2.Text;
            videos.Vid_id = VideoManager.GetIdCount() + 1;
            videos.Vid_category = HiddenField1.Value;
            if (Session["Email"] != null)
            {
               videos.email = Session["Email"].ToString();
            }
            try
            {

                if (FileVideo.HasFile)
                {
                    string filePath = FileVideo.PostedFile.FileName;
                    string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath(@"Video\") + fileName;
                    string relativepath = @"Video\" + fileName;
                    FileVideo.PostedFile.SaveAs(serverpath);
                    videos.Vid_url= relativepath;
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传视频！');</script>");
                    return;
                }
                if (FileUpload1.HasFile)
                {

                    string filePathImg = FileUpload1.PostedFile.FileName;
                    string fileNameImg = filePathImg.Substring(filePathImg.LastIndexOf("\\") + 1);
                    string serverpathImg = Server.MapPath(@"Videoimg\") + fileNameImg;
                    string relativepathImg = @"Vdeoimg\" + fileNameImg;
                    FileUpload1.PostedFile.SaveAs(serverpathImg);
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
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                if (VideoManager.addVideo(videos) == 1)
                {
                    TextBox1.Text = "";
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('添加成功！');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请输入标题！');</script>");
            }
            //}





        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AddVideoss();
        }
    }
}