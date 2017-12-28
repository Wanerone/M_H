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
  public  class SqlServerActivityJoin:IActivityJoin
    {
        public int addActivityJoin(ActivityJoin activityjoin)
        {
            string Sql = "insert into ActivityJoin values(@Activity_id,@email,@Jointime)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Activity_id",activityjoin.Activity_ID),
                new SqlParameter("@email",activityjoin.email),
                new SqlParameter("@Jointime",activityjoin.JoinTime)
            };

            return SQLHelper.GetExcuteNonQuery(Sql, sp);

        }

        public DataTable SelectID(int Activity_id)
        {
            string sql = "select  a.*,b.userName from ActivityJoin a,Users b where a.email=b.email and Activity_ID=@Activity_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Activity_id",Activity_id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public DataTable SelectAll()
        {
            string sql = "select a.userName as beforename,d.userName as aftername,c.*,b.ActName from Users a,Activity b,ActivityJoin c ,Users d where b.Activity_ID=c.Activity_ID and b.email=a.email and c.email=d.email";
            return SQLHelper.GetFillData(sql);

        }

        public int Delete(int id)
        {
            string sql = "delete from ActivityJoin where ActivityJoin_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        public int getCount(int id)
        {
            string sql = "select Count(*) from ActivityJoin where email='" + id + "'";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
    }
}
