using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IArticle
    {
        int Insert(Article art);
        //获得文章数量
        int GetId();
        string GetEmail(int id);
        DataTable SelectTop5();
        DataTable SelectAll();
        DataTable SelectAll(string email);
        DataTable SelectID(int id);
        DataTable SelectTop(int top);
        DataTable SelectLike(string like);
        int countID(string email);
    }
}
