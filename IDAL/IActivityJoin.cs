using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
 public   interface IActivityJoin
    {
        int addActivityJoin(ActivityJoin activityjoin);
        DataTable SelectID(int Activity_id);
        DataTable SelectAll();
        int Delete(int id);
        int getCount(int id);
    }
}
