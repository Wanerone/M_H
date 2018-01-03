using DALFactory;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BLL
{
   public class VideoCollectionManager
    {
        private static IVideoCollection iartcollection = DataAccess.CreateVideoCollection();
        public static int add(VideoCollection art)
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
