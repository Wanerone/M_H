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
    public class SqlServerVideo:IVideo
    {
        public int GetId()
        {
            string sql = "select count(Vid_id) from Video ";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
        public string GetEmail(int id)
        {
            string sql = "select email from Video where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        public DataTable SelectAll(string email)
        {
            string sql = "select  * from Video where email=@email order by Vid_creattime desc";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.GetFillData(sql, sp);
        }
        /// <summary>
        /// 参数赋值
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回参数数组</returns>
        private SqlParameter[] AssignParameter(Video video)
        {
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@email",video.email),
                new SqlParameter("@Vid_id",video.Vid_id),
                new SqlParameter("@Vid_url",video.Vid_url),
                new SqlParameter("@Vid_title",video.Vid_title),
                new SqlParameter("@Vid_jianjie",video.Vid_jianjie),
                new SqlParameter("@Vid_img",video.Vid_img),
                new SqlParameter("@Vid_category",video.Vid_category),
                new SqlParameter("@Vid_creattime",video.Vid_creattime),
            };

            return sp;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public int addVideo(Video video)
        {
            string sql = "insert into Video(email,Vid_id,Vid_url,Vid_title,Vid_jianjie,Vid_img,Vid_category,Vid_creattime) values( @email,@Vid_id,@Vid_url,@Vid_title,@Vid_jianjie,@Vid_img,@Vid_category,@Vid_creattime)";
    
            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(video));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="videoes">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public int addNumVideo(List<Video> videoes)
        {
            int sum = 0;
            foreach (Video item in videoes)
            {
                sum += addVideo(item);
            }

            return sum;
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public int deleteAll()
        {
            string sql = "truncate table Video";

            return SQLHelper.GetExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public int deleteKey(int id)
        {
            string sql = "delete from Video where Vid_id=@Vid_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Vid_id",id)
            };

            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public int updateVideo(Video video)
        {
            string sql = "update Video set email=@email,Vid_url=@Vid_url,Vid_title=@Vid_title,@Vid_jianjie=@Vid_jianjie,Vid_img=@Vid_img,Vid_category=@Vid_category,Vid_creattime=@Vid_creattime where Vid_id=@Vid_id";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(video));
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public DataTable selectAll()
        {
            string sql = "select * from Video";

            return SQLHelper.GetFillData(sql);
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public DataTable selectKey(int id)
        {
            string sql = "select * from Video where Vid_id=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };

            return SQLHelper.GetFillData(sql, sp);
        }

    }
}
