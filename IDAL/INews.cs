using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Models;
namespace IDAL
{
 public  interface INews
    {
        DataTable SelectTop5();
        DataTable SelectAll();
        DataTable SelectID(int News_id);
        DataTable SelectTop(int top);
        DataTable SelectKeys(string Keys);
        int addnews(News news);
        int Delete(int id);
        int updateNews(News news);
    }
}
