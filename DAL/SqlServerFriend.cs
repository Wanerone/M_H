﻿using IDAL;
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
    public class SqlServerFriend : IFriend
    {
        public int addFriend(Friend f)
        {
            string sql = "insert into Friend values(@UserA,@UserB)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@UserA",f.UserA),
                new SqlParameter("@UserB",f.UserB),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public string GetUserB(string UserA)
        {
            string sql = "select UserB from Friend where UserA=@UserA";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@UserA",UserA),
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        public int count()
        {
            string sql = "select count(*) from Friend ";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
        public int deleteFriend(string UserA,string UserB)
        {
            string sql = "delete from Friend where UserA=@UserA and UserB=@UserB";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@UserA",UserA),
                new SqlParameter("@UserB",UserB),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
   
    }
}
