using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
  public  class SqlServerVideoStatic:IVideoStatic
    {
        public int addColl(int id)
        {
            string sql = "update VideoStatic set collection=collection+1 where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);

        }
        public int Redcol(int id)
        {
            string sql = "update VideoStatic set collection=collection-1  where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public int addRead(int id)
        {
            string sql = "update VideoStatic set readCount=readCount+1 where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public int addVopte(int id)
        {
            string sql = "update VideoStatic set upVote=upVote+1 where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select  * from VideoStatic where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Getcol(int id)
        {
            string sql = "select collection from VideoStatic where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return SQLHelper.ExecuteScalar<int>(sql, sp);
        }
        public DataTable ReadTop(int top)
        {
            string sql = "select  top " + top + " b.*,a.* from VideoStatic a,Video b where a.Vid_id=b.Vid_id order by readCount desc";

            return SQLHelper.GetFillData(sql);
        }
    }
}
