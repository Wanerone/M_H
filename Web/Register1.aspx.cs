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
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.userName = TextUser.Text.Trim();
            us.password = TextPassword.Text.Trim();
            us.email = TextEmail.Text.Trim();
            us.question = TextBox1.Text.Trim();
            us.answer = TextBox2.Text.Trim();
            us.creattime = DateTime.Now;
            string checkCode = Session["CheckCode"].ToString();
            // int i = UserManger.AddUser(us);
            string j = UsersManager.SelectEmail(TextUser.Text.Trim());
            string m = UsersManager.SelectName(TextEmail.Text.Trim());
            Session["Name"]= TextUser.Text.Trim();
            Session["Email"]= TextEmail.Text.Trim();
            try
            {
                if (checkCode.ToLower() == TextCheck.Text || checkCode.ToUpper() == TextCheck.Text)
                {
                    if (m!=null)
                    {
                        Label8.Text = "邮箱已被注册！";
                    }

                    else if (j!=null)
                    {
                        Label9.Text = "已存在该用户！";
                    }


                    else if (UsersManager.AddUser(us) == 1)
                    {
                        // Response.Redirect("RegisterSucess.aspx",true);
                        Response.Write("<script language='javascript'>window.location='RegisterSucess.aspx'</script>");
                    }
                }
                else
                {
                    Label6.Text = "验证码错误";
                }
            }
            catch (Exception ex)
            {
                Response.Write("注册失败：" + ex.Message);
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length > 12)
            {
                args.IsValid = false;
                Label7.Text = "密码不超过12位";

            }
            else
                args.IsValid = true;
        }
    }
}