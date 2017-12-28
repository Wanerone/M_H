using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class MyHeadimg : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              /*  if (Session["Email"] != null)
                {
                    string m = UserInManager.GetImage(Session["Email");
                }*/
                string m = UserInManager.GetImage("222@qq.com");
                Image1.ImageUrl = m;
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string filePath = FileUpload1.PostedFile.FileName;
                string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                string serverpath = Server.MapPath(@"Image\") + filename;
                string relativepath = @"Image\" + filename;
                FileUpload1.PostedFile.SaveAs(serverpath);
                Image1.ImageUrl = relativepath;
                UserIn us = new UserIn();
                us.headimg = relativepath;
              //  us.email =Session["Email"].ToString();
                us.email = "222@qq.com";
                if (UserInManager.UpdateImage(us) == 1)
                {
                    // Page.ClientScript.RegisterStartupScript(typeof(Object), "alert", "<script>alert('保存成功！');</script>"); 
                    Response.Redirect("MyHeadimg.aspx");
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传照片！');</script>");
                return;
            }
        }
    }
}