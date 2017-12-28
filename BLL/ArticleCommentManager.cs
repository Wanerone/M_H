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
   public  class ArticleCommentManager
    {
        private static IArticleComment icomment_ac = DataAccess.CreateArticleComment();
        public static DataTable SelectAll()
        {
            return icomment_ac.SelectAll();
        }
        public static DataTable SelectID(int id)
        {
            return icomment_ac.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return icomment_ac.SelectTop(top);
        }
        public static int addComment_AC(ArticleComment ac)
        {
            return icomment_ac.addcomment_ac(ac);
        }
        public static DataTable SelectcoutID(int id)
        {
            return icomment_ac.SelectID(id);
        }

        public static int Delete(int id)
        {
            return icomment_ac.Delete(id);
        }

        public static int CountComment()
        {
            return icomment_ac.CountComment();
        }
        public static int CountComment(int id)
        {
            return icomment_ac.CountComment(id);
        }
    }
}
