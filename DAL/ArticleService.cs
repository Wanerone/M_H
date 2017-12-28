using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ArticleService
    {
       
        public static DataTable SelectTop5()
        {
            string sql = "select top 6 * from Article order by ntime desc";
            return SQLHelper.GetFillData(sql);
        }
        public static DataTable SelectAll()
        {
            string sql = "select  * from Article";
            return SQLHelper.GetFillData(sql);
        }
        public static DataTable SelectID(int id)
        {
            string sql = "select  * from Article where Art_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public static DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " * from Article order by ntime desc";

            return SQLHelper.GetFillData(sql);
        }
        /// <summary>
        /// 增加指定ID的文章
        /// </summary>
        /// <param name="art"></param>
        /// <returns></returns>
        public static int Insert(Article art)
        {
            string sql = "insert into Article values(@Art_title,@Art_content,@Art_image,@Art_creatTime)";
            SqlParameter[] sp = new SqlParameter[]{
                                                 new SqlParameter("@Art_title",art.Art_title),
                                                 new SqlParameter("@Art_content",art.Art_content),
                                                 new SqlParameter("@Art_image",art.Art_image),
                                                new SqlParameter("@Art_creatTime",art.Art_creatTime),};

            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        /// <summary>
        /// 删除指定ID的文章
        /// </summary>
        /// <param name="Art_Id"></param>
        /// <returns></returns>
        public static int deleteID(int Art_Id)
        {
            string sql = "delete from Article where Art_Id=@Art_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Art_Id)",Art_Id)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        /// <summary>
        /// 清空文章表
        /// </summary>
        /// <returns></returns>
        public static int deleteAll()
        {
            string sql = "truncate table Article";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
    }
}
