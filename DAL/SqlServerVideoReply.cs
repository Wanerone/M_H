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
  public  class SqlServerVideoReply:IVideoReply
    {
        public int addVideoReply(VideoReply reply)
        {
            string sql = "insert into VideoReply values(@reply_id,@com_id,@email,@ReplyContent,@ReplyTime)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@reply_id",reply.reply_id),
                new SqlParameter("@com_id",reply.com_id),
                new SqlParameter("@email",reply.email),
                new SqlParameter("@ReplyTime",reply.ReplyTime),
                new SqlParameter("@ReplyContent",reply.ReplyContent)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader comReturn(int comID)
        {
            string sql = "select * from VideoReply where com_id=" + comID;
            return SQLHelper.GetDataReader(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.userName as beforename,d.userName as aftername,c.* from Users a,VideoComment b,VideoReply c ,Users d where c.com_id='" + id + "'and b.com_id=c.com_id and b.email=a.email and c.email=d.email";
            DataTable dt = SQLHelper.GetFillData(sql);
            return dt;
        }
        public int Delete(int id)
        {
            string sql = "delete from VideoReply where reply_id='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select a.userName as beforename,d.userName as aftername,c.* from Users a,VideoComment b,VideoReply c ,Users d where b.com_id=c.com_id and b.email=a.email and c.email=d.email";
            return SQLHelper.GetFillData(sql);

        }
    }
}
