using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerAnime : IAnime
    {
        public int Getcount()
        {
            string sql = "select count(anime_ID) from Anime ";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
        public int Insert(Anime art)
        {
            string sql = "insert into Anime values(@anime_ID,@anime_Name,@anime_Image,@anime_Link,@addtime,@jianjie,@location,@label)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@anime_ID",art.anime_ID),
                new SqlParameter("@anime_Name",art.anime_Name),
                new SqlParameter("@anime_Image",art.anime_Image),
                new SqlParameter("@anime_Link",art.anime_Link),
                new SqlParameter("@addtime",art.addtime),
                new SqlParameter("@jianjie",art.jianjie),
                new SqlParameter("@location",art.location), 
                new SqlParameter("@label",art.label),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select  * from Anime order by addtime desc";
            return SQLHelper.GetFillData(sql);
        }

        public DataTable SelectAll(string email)
        {
            string sql = "select  * from Anime where email=@email order by addtime desc";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.GetFillData(sql, sp);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select  * from Anime where anime_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " * from Anime order by addtime desc";

            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectTopGuochan(int top)
        {
            string sql = "select  top " + top + " * from Anime  where location='中国' order by addtime desc";

            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectTopRiman(int top)
        {
            string sql = "select  top " + top + " * from Anime  where location='日本' order by addtime desc";

            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectTopJuchang(int top)
        {
            string sql = "select  top " + top + " * from Anime  where location like '%剧场版' order by addtime desc";

            return SQLHelper.GetFillData(sql);
        }
    }
}
