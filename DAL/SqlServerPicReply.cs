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
  public  class SqlServerPicReply
    {
        public int addPicReply(PicReply reply)
        {
            string sql = "insert into PicReply values(@email,@PicComment_ID,@ReplyContent,@ReplyTime)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@PicComment_ID",reply.PicComment_ID),
                new SqlParameter("@email",reply.email),
                new SqlParameter("@ReplyTime",reply.ReplyTime),
                new SqlParameter("@ReplyContent",reply.ReplyContent)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader comReturn(int comID)
        {
            string sql = "select * from PicReply where PicComment_ID=" + comID;
            return SQLHelper.GetDataReader(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.userName as beforename,d.userName as aftername,c.* from Users a,PicComment b,PicReply c ,Users d where c.PicComment_ID='" + id + "'and b.PicComment_ID=c.PicComment_ID and b.email=a.email and c.email=d.email";
            DataTable dt = SQLHelper.GetFillData(sql);
            return dt;
        }
        public int Delete(int id)
        {
            string sql = "delete from PicReply where PicReply_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select a.userName as beforename,d.userName as aftername,c.* from Users a,PicComment b,PicReply c ,Users d where b.PicComment_ID=c.PicComment_ID and b.email=a.email and c.email=d.email";
            return SQLHelper.GetFillData(sql);

        }
    }
}
