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
            UserIn ui = new UserIn();
            us.userName = TextUser.Text.Trim();
            ui.userName= TextUser.Text.Trim(); ;
            us.password = TextPassword.Text.Trim();
            us.email = TextEmail.Text.Trim();
            ui.email= TextEmail.Text.Trim();
            us.question = TextBox1.Text.Trim();
            us.answer = TextBox2.Text.Trim();
            us.creattime = DateTime.Now;
            ui.headimg ="Image/touxiang.jpg";
            ui.sex = DBNull.Value.ToString();
            ui.birthday= DBNull.Value.ToString(); 
            ui.addr= DBNull.Value.ToString(); 
            ui.perSign= DBNull.Value.ToString();
            string checkCode = Session["CheckCode"].ToString();
            // int i = UserManger.AddUser(us);
            string j = (UsersManager.GetEmail(us.email)).ToString();
            string m = (UsersManager.GetName(us.userName)).ToString();
            Session["Name"]= TextUser.Text.Trim();
            try
            {
                if (checkCode.ToLower() == TextCheck.Text || checkCode.ToUpper() == TextCheck.Text)
                {
                    if (j == TextEmail.Text.Trim())
                    {
                        Label8.Text = "邮箱已被注册";
                    }

                    else if (m == TextUser.Text.Trim())
                    {
                        Label9.Text = "用户名重复";
                    }


                    else if (UsersManager.AddUser(us) == 1&&UserInManager.Insert(ui)==1)
                    {

                        Response.Redirect("~/RegisterSucess.aspx");
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