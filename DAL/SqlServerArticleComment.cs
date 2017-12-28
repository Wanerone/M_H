using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class SqlServerArticleComment:IArticleComment
    {
        public int addcomment_ac(ArticleComment ac)
        {
            string Sql = "insert into ArticleComment values(@ArticleComment_id,@Art_id,@email,@ComContent,@ComTime)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ArticleComment_id",ac.ArticleComment_id), 
                new SqlParameter("@Art_id",ac.Art_id),
                new SqlParameter("@email",ac.email),
                new SqlParameter("@ComContent",ac.ComContent),
                new SqlParameter("@ComTime",ac.ComTime),     
            };

            return SQLHelper.GetExcuteNonQuery(Sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select  a.*,b.userName,c.Art_title from ArticleComment a, UserIn b,Article c where a.email=b.email and a.Art_id=c.Art_id";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectcoutID(int ArticleComment_id)
        {
            string sql = "select  * from ArticleComment where ArticleComment_id=@ArticleComment_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@ArticleComment_id",ArticleComment_id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " a.*,b.userName from ArticleComment a, UserIn b where a.email=b.email order by ComTime desc";

            return SQLHelper.GetFillData(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.*,b.userName,b.headimg from ArticleComment a, UserIn b where Art_id='" + id + "'and a.email=b.email order by ComTime";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("ArticleComment_id",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from ArticleComment where ArticleComment='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
      //  获得评论数量
        public int CountComment()
        {
            string sql = "select count(*) from ArticleComment";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
        public int CountComment(int id)
        {
            string sql = "select count(ArticleComment_id) from ArticleComment where Art_id=@Art_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Art_id", id),
            };
            return SQLHelper.ExecuteScalar<int>(sql,sp);
        }
    }
}
