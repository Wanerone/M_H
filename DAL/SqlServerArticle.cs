using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SqlServerArticle : IArticle
    {
        public int GetId()
        {
            string sql = "select count(Art_id) from Article ";
            return SQLHelper.ExecuteScalar<int>(sql);
        }

        public int Insert(Article art)
        {
            string sql = "insert into Article values(@email,@Art_id,@Art_title,@Art_content,@Art_image,@Art_creatTime,@Art_lable)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",art.email),
                new SqlParameter("@Art_id",art.Art_id),
                new SqlParameter("@Art_title",art.Art_title),
                new SqlParameter("@Art_content",art.Art_content),
                new SqlParameter("@Art_image",art.Art_image),
                new SqlParameter("@Art_creatTime",art.Art_creatTime),
                new SqlParameter("@Art_lable",art.Art_lable),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectTop5()
        {
            string sql = "select top 5 * from Article order by Art_creatTime desc";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select  * from Article order by Art_creatTime desc";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectAll(string email)
        {
            string sql = "select  * from Article where email=@email order by Art_creatTime desc";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.GetFillData(sql,sp);
        }
        public DataTable SelectID(int id)
        {
            string sql = "select  * from Article where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " * from Article order by Art_creatTime desc";

            return SQLHelper.GetFillData(sql);
        }

        public string GetEmail(int id)
        {
            string sql = "select email from Article where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
    }
}
