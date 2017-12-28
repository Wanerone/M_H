using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
 public   class SqlServerNews : INews
    {
        public DataTable SelectTop5()
        {
            string sql = "select top 5 * from News";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select  * from News order by News_creattime desc";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectID(int News_ID)
        {
            string sql = "select  * from News where News_ID=@News_ID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@News_ID",News_ID)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " * from News order by News_creattime desc";

            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectKeys(string Keys)
        {
            string sql = "select * from News where News_title like '%" + @Keys + "%' or News_content like '%" + @Keys + "%' or News_jianjie like '%" + @Keys + "%'";
            SqlParameter[] sp = new SqlParameter[]{
            new SqlParameter("@Keys",Keys)

           };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public int addnews(News news)
        {
            string sql = "insert into News values(@News_title,@News_creattime,@News_content,@News_jianjie,@News_image) ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@News_title",news.News_title),
                new SqlParameter("@News_creattime",news.News_creattime),
                new SqlParameter("@News_content",news.News_content),
                new SqlParameter("@News_jianjie",news.News_jianjie),
                new SqlParameter("@News_image",news.News_image)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public int Delete(int id)
        {
            string sql = "delete from News where News_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }


        public int updateNews(News news)
        {
            string sql = "update News set News_title=@News_title,News_creattime=@News_creattime,News_content=@News_content,News_image=@News_image where News_ID=@News_ID";
            SqlParameter[] sp = new SqlParameter[]
             {
                 new SqlParameter("@News_ID",news.News_ID),
                 new SqlParameter("@News_title",news.News_title),
                new SqlParameter("@News_creattime",news.News_creattime),
                new SqlParameter("@News_content",news.News_content),
                new SqlParameter("@News_image",news.News_image)
             };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

    }
}
