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
    public interface IUsers
    {
        string SelectName(string email) ;
        string SelectEmail(string userName);
        int Insert(Users us);
        SqlDataReader login(string email, string pwd);
        SqlDataReader GetEmail(string email);
        SqlDataReader GetName(string name);
    }
}
