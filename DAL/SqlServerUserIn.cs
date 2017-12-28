using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    class SqlServerUserIn : IUserIn
    {
        public int Insert(UserIn us)
        {
            string sql = "insert into UserIn values(@email,@userName,@headimg,@sex,@birthday,@addr,@perSign)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",us.email),
                new SqlParameter("@username",us.userName),
                new SqlParameter("@headimg",us.headimg),
                new SqlParameter("@sex",us.sex),
                new SqlParameter("@birthday",us.birthday),
                new SqlParameter("@addr",us.addr),
                new SqlParameter("@perSign",us.perSign),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectID(string email)
        {
            string sql = "select * from UserIn where email=@email";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email),
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Updata(UserIn us)
        {
            string sql = "update UserIn set userName=@userName,sex=@sex,birthday=@birthday,addr=@addr,perSign=@perSign where email=@email";
            SqlParameter[] sp = new SqlParameter[]{
                 new SqlParameter("@email",us.email),
                new SqlParameter("@username",us.userName),
                //new SqlParameter("@headimg",us.headimg),
                new SqlParameter("@sex",us.sex),
                new SqlParameter("@birthday",us.birthday),
                new SqlParameter("@addr",us.addr),
                new SqlParameter("@perSign",us.perSign),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public int UpdateImage(UserIn us)
        {
            string sql = "update UserIn set headimg=@headimg where email=@email";
            SqlParameter[] sp = new SqlParameter[]{
                 new SqlParameter("@email",us.email),
                 new SqlParameter("@headimg",us.headimg),
             };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public string GetperSign(string email)
        {
            string sql = "select perSign from UserIn where @email=email ";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        public string GetImage(string email)
        {
            string sql = "select headimg from UserIn where @email=email ";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
    }
}
