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
    public class ArtStaticManager
    {
        public static IArtStatic iartstatic = DataAccess.CreateArtStatic();
        public static int addRead(int id)
        {
            return iartstatic.addRead(id);
        }

        public static int addColl(int id)
        {
            return iartstatic.addColl(id);
        }
        public static int RedColl(int id)
        {
            return iartstatic.Redcol(id);
        }
        public static int addVote(int id)
        {
            return iartstatic.addVopte(id);
        }
        public static DataTable SelectID(int id)
        {
            return iartstatic.SelectID(id);
        }

        public static int Getcol(int id)
        {
            return iartstatic.Getcol(id);
        }
        public static DataTable Readtop(int top)
        {
            return iartstatic.ReadTop(top);
        }
    }
}
