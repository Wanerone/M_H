using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface IManagers
    {
        SqlDataReader ManagersLogin(string adminname, string pwd);
        bool AddManager(Managers manager);
        DataTable SelectAll();
        int Count();
        int Delete(string name);
        DataTable selectKey(int id); //按编号查询
    }
}
