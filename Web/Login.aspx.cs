using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];
                if (cookie != null)
                {
                    UserName.Text = Server.HtmlEncode(cookie.Values["email"]);
                    Password.Text = Server.HtmlEncode(cookie.Values["password"]);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string email = UserName.Text.Trim();
            string pwd = Password.Text.Trim();
            Session["Email"] = email;
            //获取验证码
            string checkCode = Session["CheckCode"].ToString();
            
                if (checkCode.ToLower() == TextBox2.Text || checkCode.ToUpper() == TextBox2.Text)
                {
                    SqlDataReader dr = UsersManager.login(email, pwd);
                    if (dr.Read())
                    {
                        string name = UsersManager.SelectName(email);
                        Session.Add("Name", name);
                        //  Label2.Text=  Session["Name"].ToString();
                        Response.Redirect("~/WebF.aspx");
                    }
                    else
                    {
                        Label4.Text = "用户名或密码错误！";
                    }

                }
                else
                {
                    Label3.Text = "验证码输入有误!";
                }
            
          

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie.Values["email"] = UserName.Text.Trim();
                cookie.Values["password"] = Password.Text.Trim();
                cookie.Expires = System.DateTime.Now.AddDays(30);
                Response.Cookies.Add(cookie);
            }
        }
    }
}