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
    class SqlServerArticleReply:IArticleReply
    {
        public int addreply_art(ArticleReply ar)
        {
            string sql = "insert into ArticleReply values(@ArticleReply_id,@ArticleComment_id,@email,@ReplyContent,@ReplyTime)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ArticleReply_id",ar.ArticleReply_id),
                new SqlParameter("@ArticleComment_id",ar.ArticleComment_id),
                new SqlParameter("@email",ar.email),
                new SqlParameter("@ReplyContent",ar.ReplyContent),
                new SqlParameter("@ReplyTime",ar.ReplyTime),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);

        }
        public DataTable selectID(int id)
        {
            string sql = "select * from ArticleReply where ArticleComment_id=@ArticleComment_id";
            DataTable dt = SQLHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.UserName as beforename,d.UserName as aftername,c.* from Users a,ArticleComment b,ArticleReply c ,Users d where c.ArticleComment_id='" + id + "'and b.ArticleComment_id=c.ArticleComment_id and b.email=a.email and c.email=d.email";
            DataTable dt = SQLHelper.GetFillData(sql);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from ArticleReply where ArticleReply_id='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select a.UserName as beforename,d.UserName as aftername,c.* from Users a,ArticleComment b,ArticleReply c ,Users d where b.ArticleComment_id=c.ArticleComment_id and b.email=a.email and c.email=d.email";
            return SQLHelper.GetFillData(sql);
        }
        public int CountReply()
        {
            string sql = "select count(*) from ArticleReply";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
    }
}
