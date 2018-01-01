using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class AnimeReplyManager
    {
        private static IAnimeReply ireply_art = DataAccess.CreateAnimeReply();

        public static int addreply(AnimeReply ar)
        {
            return ireply_art.addreply(ar);
        }
        public static DataTable selectID(int id)
        {
            return ireply_art.selectID(id);
        }
        public static DataTable SelectID(int id)
        {
            return ireply_art.SelectID(id);
        }

        public static int Delete(int id)
        {
            return ireply_art.Delete(id);

        }

        public static DataTable SelectAll()
        {
            return ireply_art.SelectAll();
        }
        public static int CountReply()
        {
            return ireply_art.CountReply();
        }
    }
}
