using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
 public   class ManagersManager
    {
        public static IManagers imanagers = DataAccess.CreateManagers();
        public static SqlDataReader ManagersLogin(string adminname, string pwd)
        {
            return imanagers.ManagersLogin(adminname, pwd);
        }

        public static bool AddManager(Managers manager)
        {
            return imanagers.AddManager(manager);
        }

        public static DataTable SelectAll()
        {
            return imanagers.SelectAll();
        }

        public static int Count()
        {
            return imanagers.Count();
        }

        public static int Delete(string name)
        {
            return imanagers.Delete(name);
        }
        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public static DataTable selectKey(int id)
        {
            return imanagers.selectKey(id);
        }
    }
}
