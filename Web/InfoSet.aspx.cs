using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class InfoSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 if (Session["Name"] != null && Session["Email"]!=null)
                 {
                     TextBox1.Text = Session["Name"].ToString();
                     Label1.Text = Session["Email"].ToString();
                    if (UserInManager.GetperSign(Label1.Text)==null)
                    {
                    TextBox2.Text ="";
                    }
                    else
                    {
                        TextBox2.Text = UserInManager.GetperSign(Label1.Text);
                    }
                    
                }
                
                 //TextBox2.Text = UserInManager.GetperSign(Session["Eemail"].ToString());
                // TextBox1.Text = "泛泛而谈";
               //  Label1.Text = "222@qq.com";
                 //TextBox2.Text = UserInManager.GetperSign(Label1.Text);
                RadioButtonList1.SelectedValue = "男";
                Label2.Text = "";
                BindProvince();
                BindCity(bind_Province.SelectedItem.Value);
                BindBorough(bind_City.SelectedItem.Value);
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserIn us = new UserIn();
            us.email = Session["Email"].ToString();
            //us.email = "222@qq.com";
            us.userName = TextBox1.Text.Trim();
            string m = UsersManager.SelectEmail(us.userName);
            us.sex = RadioButtonList1.SelectedValue;
            us.birthday = TextBox3.Text.Trim();
            // us.addr = HiddenField1.Value;
            us.addr = bind_Province.SelectedItem.Text+ bind_City.SelectedItem.Text + bind_Borough.SelectedItem.Text;
            us.perSign = TextBox2.Text.Trim();
            if(m !=us.email)
                {
                Label2.Text = "已有该用户!";
                }
            else if(UserInManager.Updata(us)==1)
            {
            ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('保存成功!')</script>");
                Response.Redirect("InfoSet.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('保存失败')</script>");
            }
            }

        //BindProcince(),BindCity(),BindBorough()用来绑定省市县三个下拉框
        private void BindProvince()
        {

            string sql = "select provCode,provName from t_pub_province";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserCnnString"].ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            bind_Province.DataSource = ds.Tables[0];
            bind_Province.DataValueField = "provCode";
            bind_Province.DataTextField = "provName";
            bind_Province.DataBind();

        }
        private void BindCity(string code)
        {
            string provinceCode = code.Substring(0, 2);
            string sql = "select cityCode,cityName from t_pub_city where left(cityCode,2)='" + provinceCode + "'";
            //省份和城市进行关联
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserCnnString"].ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            bind_City.DataSource = ds.Tables[0];
            bind_City.DataValueField = "cityCode";
            bind_City.DataTextField = "cityName";
            bind_City.DataBind();

        }

        private void BindBorough(string code)
        {
            string cityCode = code.Substring(0, 4);
            //城市和地区进行关联
            string sql = "select boroCode,boroName from t_pub_borough where left(boroCode,4)='" + cityCode + "'";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserCnnString"].ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            bind_Borough.DataSource = ds.Tables[0];
            bind_Borough.DataValueField = "boroCode";
            bind_Borough.DataTextField = "boroName";
            bind_Borough.DataBind();
        }


        protected void bind_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindBorough(bind_City.SelectedItem.Value);
        }

        protected void bind_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCity(bind_Province.SelectedItem.Value);
            BindBorough(bind_City.SelectedItem.Value);
        }
    }
}