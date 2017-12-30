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
    public class AnimeStaticManager
    {
        public static IAnimeStatic iastatic = DataAccess.CreateAnimeStatic();
        public static int addRead(int id)
        {
            return iastatic.addRead(id);
        }

        public static int addColl(int id)
        {
            return iastatic.addColl(id);
        }
        public static int RedColl(int id)
        {
            return iastatic.Redcol(id);
        }
        public static int addVote(int id)
        {
            return iastatic.addVopte(id);
        }
        public static DataTable SelectID(int id)
        {
            return iastatic.SelectID(id);
        }

        public static int Getcol(int id)
        {
            return iastatic.Getcol(id);
        }

        public static int GetState(int id)
        {
            return iastatic.GetState(id);
        }

        public static int UpdateTrue(int id)
        {
            return iastatic.UpdateTrue(id);
        }

        public static int UpdateFalse(int id)
        {
            return iastatic.UpdateFalse(id);
        }
    }
}
