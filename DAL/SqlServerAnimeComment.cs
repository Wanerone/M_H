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
    public class SqlServerAnimeComment:IAnimeComment
    {
        public int addcomment_ac(AnimeComment ac)
        {
            string Sql = "insert into AnimeComment values(@anime_ID,@email,@comment,@time)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@anime_ID",ac.@anime_ID),
                new SqlParameter("@email",ac.email),
                new SqlParameter("@comment",ac.comment),
                new SqlParameter("@time",ac.time),
            };

            return SQLHelper.GetExcuteNonQuery(Sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select  a.*,b.userName,c.Art_title from AnimeComment a, UserIn b,Anime c where a.email=b.email and a.anime_ID=c.anime_ID";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectcoutID(int id)
        {
            string sql = "select  * from AnimeComment where com_id=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " a.*,b.userName from AnimeComment a, UserIn b where a.email=b.email order by time desc";

            return SQLHelper.GetFillData(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.*,b.userName,b.headimg from AnimeComment a, UserIn b where anime_ID='" + id + "'and a.email=b.email order by time";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@anime_ID",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from AnimeComment where com_id='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        //  获得评论数量
        public int CountComment()
        {
            string sql = "select count(*) from AnimeComment";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
        public int CountComment(int id)
        {
            string sql = "select count(AnimeComment_id) from AnimeComment where anime_ID=@anime_ID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@anime_ID", id),
            };
            return SQLHelper.ExecuteScalar<int>(sql, sp);
        }
    }
}
