using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Data.SqlClient;
using Models;

namespace DAL
{
   public class SqlServerAnimeCollection:IAnimeCollection
    {
        public int add(AnimeCollection art)
        {
            string sql = "insert into AnimeCollection values(@email,@anime_ID,@colState)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",art.email),
                new SqlParameter("@anime_ID",art.anime_ID),
                new SqlParameter("@colState",art.colState),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        //获得收藏状态
        public string GetState(string email, int id)
        {
            string sql = "select colState from AnimeCollection where email=@email and anime_ID=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        //收藏状态更新为1
        public int UpdateTrue(string email, int id)
        {
            string sql = "update AnimeCollection set colState='N'  where anime_ID=@id";
            SqlParameter[] sp = new SqlParameter[]
           {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id),
           };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        //收藏状态更新为0
        public int UpdateFalse(string email, int id)
        {
            string sql = "update AnimeCollection set colState='F'  where email=@email and anime_ID=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
