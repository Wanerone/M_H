using DALFactory;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class VideoStaticManager
    {
        public static IVideoStatic ivideostatic = DataAccess.CreateVideoStatic();
        public static int addRead(int id)
        {
            return ivideostatic.addRead(id);
        }

        public static int addColl(int id)
        {
            return ivideostatic.addColl(id);
        }
        public static int RedColl(int id)
        {
            return ivideostatic.Redcol(id);
        }
        public static int addVote(int id)
        {
            return ivideostatic.addVopte(id);
        }
        public static DataTable SelectID(int id)
        {
            return ivideostatic.SelectID(id);
        }

        public static int Getcol(int id)
        {
            return ivideostatic.Getcol(id);
        }
    }
}
