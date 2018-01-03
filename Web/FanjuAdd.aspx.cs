using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;

namespace Web
{
    public partial class FanjuAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Anime art = new Anime();
           // art.anime_ID = AnimeManager.Getcount() + 1;
            art.addtime = TextBox6.Text.Trim();
            art.anime_Link = TextBox2.Text.Trim();
            art.anime_Name = TextBox1.Text.Trim();
            art.jianjie = TextBox3.Text.Trim();
            art.location = TextBox4.Text.Trim();
            art.label = TextBox5.Text.Trim();
            if (FileUpload1.HasFile)
            {
                string filePath = FileUpload1.PostedFile.FileName;
                string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                string serverpath = Server.MapPath(@"Image\") + filename;
                string relativepath = @"Image\" + filename;
                FileUpload1.PostedFile.SaveAs(serverpath);
                art.anime_Image = relativepath;
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传照片！');</script>");
                return;
            }
            if (AnimeManager.AddAnime(art)== 1)
            {
               // Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('动画上传成功！');</script>");
                ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('动画上传成功')</script>");
                Response.Redirect("FanjuAdd.aspx");
            }
        }
    }
}