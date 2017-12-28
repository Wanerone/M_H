using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "ckfinder/";  //设置CKFinder的基路径  
            fileBrowser.SetupCKEditor(txtContent);
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(txtContent.Text))
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请输入信息后再点击！');</script>");
            }
            else
            {
                Models.Article art = new Models.Article();
                if (Session["Email"] != null)
                {
                    art.email = Session["Email"].ToString();
                }
                else art.email = DBNull.Value.ToString();
                art.Art_id = ArticleManager.GetIdCount()+1;
                art.Art_title = TextBox1.Text;
                art.Art_creatTime = System.DateTime.Now;
                art.Art_content = txtContent.Text;
                art.Art_lable = HiddenField1.Value;
                if (FileUpload1.HasFile)
                {
                    string filePath = FileUpload1.PostedFile.FileName;
                    string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath(@"Image\") + filename;
                    string relativepath = @"Image\" + filename;
                    FileUpload1.PostedFile.SaveAs(serverpath);
                    art.Art_image = relativepath;
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传照片！');</script>");
                    return;
                }
                if (ArticleManager.AddArticle(art) == 1)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('文章上传成功！');</script>");
                    Response.Redirect("WebT.aspx");
                }
            }
        }
    }
}