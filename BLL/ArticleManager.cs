using DAL;
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
   public  class ArticleManager
    {
        private static IArticle isarticle = DataAccess.CreateArticle();
        public static DataTable SelectTop5()
        {
            return isarticle.SelectTop5();
        }
        public static DataTable SelectAll()
        {
            return isarticle.SelectAll();
        }
        public static DataTable SelectAll(string email)
        {
            return isarticle.SelectAll(email);
        }
        public static DataTable SelectID(int id)
        {
            return isarticle.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return isarticle.SelectTop(top);
        }
        public static int AddArticle(Article art)
        {
            return isarticle.Insert(art);
        }
        public static int GetIdCount()
        {
            return isarticle.GetId();
        }
        public static string  GetEmail(int id)
        {
            return isarticle.GetEmail(id);
        }
        public static DataTable SelectLike(string like)
        {
            return isarticle.SelectLike(like);
        }
    }
}
