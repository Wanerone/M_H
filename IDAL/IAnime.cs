using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public  interface IAnime
    {
        int Insert(Anime art);
        int Getcount();
        DataTable SelectTop(int top);
        DataTable SelectTopGuochan(int top);
        DataTable SelectTopRiman(int top);
        DataTable SelectTopJuchang(int top);
        DataTable SelectAll();
        DataTable SelectAll(string email);
        DataTable SelectID(int id);
    }
}
