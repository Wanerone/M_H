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
 public   class ActivityJoinManager
    {
        private static IActivityJoin ijoinactivity = DataAccess.CreateActivityJoin();

        public static int addjoinactivity(ActivityJoin joinactivity)
        {
            return ijoinactivity.addActivityJoin(joinactivity);
        }

        public static DataTable SelectID(int id)
        {
            return ijoinactivity.SelectID(id);
        }

        public static DataTable SelectAll()
        {
            return ijoinactivity.SelectAll();
        }
        public static int Delete(int id)
        {
            return ijoinactivity.Delete(id);
        }
        public static int getCount(int id)
        {
            return ijoinactivity.getCount(id);
        }
    }
}
