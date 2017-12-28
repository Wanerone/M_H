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
  public  class SqlServerManager : IManagers
    {
        public SqlDataReader ManagersLogin(string adminname, string pwd)
        {
            string sql = "select * from Managers where Name='" + adminname + "' and Password='" + pwd + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Name",adminname),
                new SqlParameter("@Password",pwd)
            };
            return SQLHelper.GetDataReader(sql, sp);
        }
        //添加管理员
        public bool AddManager(Managers manager)
        {
            string sql = "insert into Managers Values (@Name,@Password)";
            SqlParameter[] sp = new SqlParameter[]
             {
                new SqlParameter("@Name",manager.Name),
                new SqlParameter("@Password",manager.Password)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp) > 0;
        }
        //查询所有管理员
        public DataTable SelectAll()
        {
            string sql = "select * from Managers";
            return SQLHelper.GetFillData(sql);
        }
        //统计管理员数量
        public int Count()
        {
            string sql = "select count(*) from Managers";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
        //删除管理员
        public int Delete(string name)
        {
            string sql = "delete from Managers where Name='" + name + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public DataTable selectKey(int id)
        {
            string sql = "select * from Managers where Managers_id=@Managers_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Managers_id",id)
            };

            return SQLHelper.GetFillData(sql, sp);
        }
    }
}
