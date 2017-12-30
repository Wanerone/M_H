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
    public class AnimeManager
    {
        private static IAnime ianime = DataAccess.CreateAnime();
        public static DataTable SelectAll(string email)
        {
            return ianime.SelectAll(email);
        }
        public static DataTable SelectID(int id)
        {
            return ianime.SelectID(id);
        }
        public static DataTable SelectAll()
        {
            return ianime.SelectAll();
        }
        public static DataTable Selectall()
        {
            return ianime.Selectall();
        }
        public static DataTable SelectTop(int top)
        {
            return ianime.SelectTop(top);
        }
        public static DataTable SelectTopGuochan(int top)
        {
            return ianime.SelectTopGuochan(top);
        }
        public static DataTable SelectGuochangAll()
        {
            return ianime.SelectGuochanAll();
        }
        public static DataTable SelectTopRiman(int top)
        {
            return ianime.SelectTopRiman(top);
        }
        public static DataTable SelectRimanAll()
        {
            return ianime.SelectRimanAll();
        }
        public static DataTable SelectTopJuchang(int top)
        {
            return ianime.SelectTopJuchang(top);
        }
        public static DataTable SelectJuchangAll()
        {
            return ianime.SelectJuchangAll();
        }
        public static int AddAnime(Anime art)
        {
            return ianime.Insert(art);
        }

        public static int Getcount()
        {
            return ianime.Getcount();
        }
    }
}
