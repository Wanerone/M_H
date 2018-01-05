using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlServerArtStatic : IArtStatic
    {
        public int addColl(int id)
        {
            //更新收藏数+!
            string sql = "update ArtStatic set collection=collection+1 where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);

        }
        //更新收藏数-!
        public int Redcol(int id)
        {
            string sql = "update ArtStatic set collection=collection-1  where Art_id=@id";         
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        //更新阅读数+!
        public int addRead(int id)
        { 
            string sql = "update ArtStatic set readCount=readCount+1 where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        //更新点赞数+1
        public int addVopte(int id)
        {
            string sql = "update ArtStatic set upVote=upVote+1 where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select  * from ArtStatic where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        //获得收藏数
        public int Getcol(int id)
        {
            string sql = "select collection from ArtStatic where Art_id=@id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
           return SQLHelper.ExecuteScalar<int>(sql, sp);
        }
        public DataTable ReadTop(int top)
        {
            string sql = "select  top " + top + " b.*,a.* from ArtStatic a,Article b where a.Art_id=b.Art_id order by readCount desc";

            return SQLHelper.GetFillData(sql);
        }
    }
}

