using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserInManager
    {
        private static IUserIn iuserin = DataAccess.CreateUserIn();
        public static int Insert(UserIn us)
        {
            return iuserin.Insert( us);
        }
        public static DataTable SelectID(string email)
        {
            return iuserin.Selectid(email);
        }
        public static int Updata(UserIn us)
        {
            return iuserin.Updata(us);
        }
        public static int UpdateImage(UserIn us)
        {
            return iuserin.UpdateImage(us);
        }
        public static string GetperSign(string email)
        {
            return iuserin.GetperSign(email);
        }
        public static string GetImage(string email)
        {
            return iuserin.GetImage(email);
        }
    }
}
