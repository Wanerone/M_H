using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class SqlServerArtCollection:IArtCollection
    {
        public int add(ArtCollection art)
        {
            string sql = "insert into ArtCollection values(@email,@Art_id,@colState)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",art.email),
                new SqlParameter("@Art_id",art.Art_id),
                new SqlParameter("@colState",art.colState),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public string GetEmail(int id)
        {
            string sql = "select email from ArtCollection where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id",id),
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        //获得收藏状态
        public string GetState(string email,int id)
        {
            string sql = "select colState from ArtCollection where email=@email and Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        //收藏状态更新为1
        public int UpdateTrue(string email,int id)
        {
            string sql = "update ArtCollection set colState='N'  where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
           {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id),
           };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        //收藏状态更新为0
        public int UpdateFalse(string email,int id)
        {
            string sql = "update ArtCollection set colState='F'  where email=@email and Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
