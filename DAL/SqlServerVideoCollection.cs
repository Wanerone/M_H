using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerVideoCollection:IVideoCollection
    {
        public int add(VideoCollection art)
        {
            string sql = "insert into VideoCollection values(@email,@Vid_id,@colState)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",art.email),
                new SqlParameter("@Vid_id",art.Vid_id),
                new SqlParameter("@colState",art.colState),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        //获得收藏状态
        public string GetState(string email, int id)
        {
            string sql = "select colState from VideoCollection where email=@email and Vid_id=@id";
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
            string sql = "update VideoCollection set colState='N'  where Vid_id=@id";
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
            string sql = "update VideoCollection set colState='F'  where email=@email and Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",email),
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
