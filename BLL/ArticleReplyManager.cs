using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;
using Models;

namespace BLL
{
   public class ArticleReplyManager
    {
        private static  IArticleReply ireply_art = DataAccess.CreateArticleReply();

        public static int addreply_art(ArticleReply ar)
        {
            return ireply_art.addreply_art(ar);
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
