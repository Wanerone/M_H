using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface IVideoStatic
    {

        int addRead(int id);
        int addVopte(int id);
        int addColl(int id);
        DataTable SelectID(int id);
        int Getcol(int id);
        int Redcol(int id);
    }
}
