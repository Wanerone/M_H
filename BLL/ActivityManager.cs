using DAL;
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
  public  class ActivityManager
    {
        private static IActivity iactivity = DataAccess.CreateActivity();

        public static DataTable SelectAll()
        {
            return iactivity.SelectAll();
        }

        public static DataTable SelectID(int id)
        {
            return iactivity.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return iactivity.SelectTop(top);
        }
        public static DataTable SelectKeys(string Keys)
        {
            return iactivity.SelectKeys(Keys);
        }
        public static int addActivity(Activity activity)
        {
            return iactivity.addActivity(activity);
        }

        public static int Delete(int id)
        {
            return iactivity.Delete(id);
        }
        //public static int praise(int id)
        //{
        //    return iactivity.praise(id);
        //}
        public static DataTable SelectUserName(string user)
        {
            return iactivity.SelectUserName(user);
        }
        public static DataTable SelectUser(string user)
        {
            return iactivity.SelectUser(user);
        }
    }
}
