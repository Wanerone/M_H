using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDAL
{
  public  interface IActivity
    {
        int addActivity(Activity activity);
        DataTable SelectAll();
        DataTable SelectID(int Activity_id);
        DataTable SelectTop(int top);
        int Delete(int id);
        //int praise(int id);
        DataTable SelectKeys(string Keys);
        DataTable SelectUser(string user);
        DataTable SelectUserName(string user);
    }
}
