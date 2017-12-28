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
   public class SqlServerPicComment:IPicComment
    {

        public int addcomment_picture(PicComment comment_pic)
        {
            string sql = "insert into PicComment values(@Pic_ID,@email,@ComContent,@ComTime)";
            SqlParameter[] sp = new SqlParameter[]
            {


                 new SqlParameter("@Pic_ID",comment_pic.Pic_ID),
                  new SqlParameter("@email",comment_pic.email),
                new SqlParameter("@ComContent",comment_pic.ComContent),
                 new SqlParameter("@ComTime",comment_pic.ComTime)

            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select  a.*,b.userName,c.Name from PicComment a, Users b,Picture c where a.Users_id=b.email and a.email=c.Pic_id";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectcoutID(int PicComment_ID)
        {
            string sql = "select  * from PicComment where  PicComment_ID=@ PicComment_ID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@ PicComment_ID", PicComment_ID)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " a.*,b.userName from PicComment a, Users b where a.email=b.email order by ComTime desc";

            return SQLHelper.GetFillData(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.*,b.userName from PicComment a, Users b where Vid_id='" + id + "'and a.email=b.email order by ComTime";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@PicComment_ID",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from PicComment where PicComment_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }

        public int CountComment()
        {
            string sql = "select count(*) from PicComment";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
    }
}
