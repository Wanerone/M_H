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
    public class SqlServerAnimeReply:IAnimeReply
    {
        public int addreply(AnimeReply ar)
        {
            string sql = "insert into AnimeReply values(@com_id,@reply_id,@email,@reply_content,@reply_time)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@com_id",ar.com_id),
                new SqlParameter("@reply_id",ar.reply_id),
                new SqlParameter("@email",ar.email),
                new SqlParameter("@reply_content",ar.reply_content),
                new SqlParameter("@reply_time",ar.reply_time),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);

        }
        public DataTable selectID(int id)
        {
            string sql = "select * from AnimeReply where com_id=@id";
            DataTable dt = SQLHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.UserName as beforename,d.UserName as aftername,c.* from Users a,AnimeComment b,AnimeReply c ,Users d where c.com_id='" + id + "'and b.com_id=c.com_id and b.email=a.email and c.email=d.email";
            DataTable dt = SQLHelper.GetFillData(sql);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from AnimeReply where reply_id='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select a.UserName as beforename,d.UserName as aftername,c.* from Users a,AnimeComment b,AnimeReply c ,Users d where b.com_id=c.com_id and b.email=a.email and c.email=d.email";
            return SQLHelper.GetFillData(sql);
        }
        public int CountReply()
        {
            string sql = "select count(*) from AnimeReply";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
    }
}
