using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class AnimeCollectionManager
    {
        private static IAnimeCollection iartcollection = DataAccess.CreateAnimeCollection();
        public static int add(AnimeCollection art)
        {
            return iartcollection.add(art);
        }
        public static string GetState(string email, int id)
        {
            return iartcollection.GetState(email, id);
        }

        public static int UpdateTrue(string email, int id)
        {
            return iartcollection.UpdateTrue(email, id);
        }

        public static int UpdateFalse(string email, int id)
        {
            return iartcollection.UpdateFalse(email, id);
        }
    }
}
