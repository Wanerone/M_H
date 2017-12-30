using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IAnimeStatic
    {
        int addRead(int id);
        int addVopte(int id);
        int addColl(int id);
        DataTable SelectID(int id);
        int Getcol(int id);
        int Redcol(int id);
        int GetState(int id);
        int UpdateTrue(int id);
        int UpdateFalse(int id);
    }
}
