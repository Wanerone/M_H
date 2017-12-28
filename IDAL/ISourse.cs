using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface ISourse
    {
        DataTable SelectAll();
        DataTable SelectID(int sourse_id);
        DataTable SelectSourseTop(int top);
        int Insert(Sourse sourse);
        int Delete(int id);
        int UpdateSourse(Sourse sourse);
    }
}
