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
 public   class NewsManager
    {
        private static INews inew = DataAccess.CreateNews();
        public static DataTable SelectTop5()
        {
            return inew.SelectTop5();
        }
        public static DataTable SelectAll()
        {
            return inew.SelectAll();
        }
        public static DataTable SelectID(int id)
        {
            return inew.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return inew.SelectTop(top);
        }
        public static DataTable SelectKeys(string Keys)
        {
            return inew.SelectKeys(Keys);
        }
        public static int addnews(News news)
        {
            return inew.addnews(news);
        }

        public static int Delete(int id)
        {
            return inew.Delete(id);
        }
        public static int updateNews(News news)
        {
            return inew.updateNews(news);
        }
    }
}
