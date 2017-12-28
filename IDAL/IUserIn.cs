using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IUserIn
    {
        int Insert(UserIn us);
        int Updata(UserIn us);
        int UpdateImage(UserIn us);
        DataTable Selectid(string email);
        string GetperSign(string email);

        string GetImage(string email);
    }
}
