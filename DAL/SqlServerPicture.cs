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
    public class SqlServerPicture:IPicture
    {
       
        /// <summary>
        /// 参数赋值
        /// </summary>
        /// <param name="picture"></param>
        /// <returns>返回参数数组</returns>
        private SqlParameter[] AssignParameter(Picture picture)
        {
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@email",picture.email),
                new SqlParameter("@Pic_ID",picture.Pic_ID),
                new SqlParameter("@Pic_url",picture.Pic_url),
                new SqlParameter("@Pic_title",picture.Pic_title),
                new SqlParameter("@Pic_description",picture.Pic_description),
                //new SqlParameter("@Vid_category",picture.),
                new SqlParameter("@Pic_creattime",picture.Pic_creattime),
            };

            return sp;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="picture"></param>
        /// <returns>返回受影响行数</returns>
        public int Insert(Picture picture)
        {
            string sql = "insert into Picture(email,Pic_ID,Pic_url,Pic_title,Pic_description,Pic_creattime) values( @email,@Pic_ID,@Pic_url,@Pic_title,@Pic_description,@Pic_creattime)";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(picture));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="pictures">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public int addNumPicture(List<Picture> pictures)
        {
            int sum = 0;
            foreach (Picture item in pictures)
            {
                sum += Insert(item);
            }

            return sum;
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public int deleteAll()
        {
            string sql = "truncate table Picture";

            return SQLHelper.GetExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public int DeleteID(int id)
        {
            string sql = "delete from Picture where Pic_ID=@Pic_ID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Pic_ID",id)
            };

            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="picture"></param>
        /// <returns>返回受影响行数</returns>
        public int UpdatePic(Picture picture)
        {
            string sql = "update Picture set email=@email,Pic_url=@Pic_url,Pic_title=@Pic_title,Pic_description=@Pic_description,Pic_creattime=@Pic_creattime where Pic_ID=@Pic_ID";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(picture));
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public DataTable SelectAll()
        {
            string sql = "select * from Picture";

            return SQLHelper.GetFillData(sql);
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public DataTable SelectID(int id)
        {
            string sql = "select * from Picture where Pic_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };

            return SQLHelper.GetFillData(sql, sp);
        }
        public DataTable SelectPicTop(int top)
        {
            string sql = "select  top " + top + " * from Picture order by Pic_creattime desc";
            return SQLHelper.GetFillData(sql);
        }
    }
}
