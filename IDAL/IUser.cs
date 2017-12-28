using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IUser
    {
        string SelectName(string email) ;
        int Insert(UserIn us);
        SqlDataReader login(string name, string pwd);
        SqlDataReader GetEmail(string email);
        SqlDataReader GetName(string name);
    }
}
