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
  public  class SqlServerActivity:IActivity
    {
        public int addActivity(Activity activity)
        {
            string sql = "insert into Activity values(@email,@ActivityName,@Addtime,@ActivityContent,@ActivityImage,@PeopleCount,@Endtime,@where)";
            SqlParameter[] sp = new SqlParameter[]
             {
             new SqlParameter("@email",activity.email),
             new SqlParameter("@ActivityName",activity.ActName),
             new SqlParameter("@Addtime",activity.ActBeginTime),
             new SqlParameter("@ActivityContent",activity.ActContent),
             new SqlParameter("@ActivityImage",activity.ActImage),
             new SqlParameter("@PeopleCount",activity.UsersCount),
             new SqlParameter("@Endtime",activity.ActEndtime),
             new SqlParameter("@where",activity.ActPlace),

         };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectKeys(string Keys)
        {
            string sql = "select * from Activity a, Users b where a.Users_id=b.email and (ActName like '%" + @Keys + "%' or userName like '%" + @Keys + "%')";
            SqlParameter[] sp = new SqlParameter[]{
            new SqlParameter("@Keys",Keys)

           };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectAll()
        {
            string sql = "select a.*,b.userName from Activity a, Users b where a.email=b.email order by ActBeginTime desc";

            return SQLHelper.GetFillData(sql);
        }

        public DataTable SelectID(int Activity_id)
        {
            string sql = "select  a.*,b.userName from Activity a,users b where Activity_ID=@Activity_ID and a.email=b.email";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Activity_ID",Activity_id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " a.*,b.userName from Activity a, Users b where a.email=b.email order by ActBeginTime desc";

            return SQLHelper.GetFillData(sql);
        }

        public int Delete(int id)
        {
            string sql = "delete from Activity where Activity_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        //public int praise(int id)
        //{
        //    string sql = "update Activity set joincout=joincout+1 where Activity_id=@Activity_id";
        //    SqlParameter[] sp = new SqlParameter[]{
        //        new SqlParameter("@Activity_id",id)
        //    };
        //    return SQLHelper.GetExcuteNonQuery(sql, sp);
        //}
        public DataTable SelectUserName(string user)
        {
            string sql = "select a.*,b.userName from Activity a, Users b,JoinActivity c where a.Activity_ID=c.Activity_IDand c.email=b.email and userName='" + user + "'";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectUser(string user)
        {
            string sql = "select a.*,b.userName from Activity a, Users b where a.email=b.email and userName='" + user + "'";
            return SQLHelper.GetFillData(sql);
        }
    }
}
