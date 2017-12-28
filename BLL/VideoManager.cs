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
   public  class VideoManager
    {
        private static IVideo ivideo = DataAccess.CreateVideo();

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public static int addVideo(Video video)
        {
            return ivideo.addVideo(video);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="videoes">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public static int addNumVideo(List<Video> videoes)
        {
            return ivideo.addNumVideo(videoes);
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public static int deleteAll()
        {
            return ivideo.deleteAll();
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public static int deleteKey(int id)
        {
            return ivideo.deleteKey(id);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public static int updateVideo(Video video)
        {
            return ivideo.updateVideo(video);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public static DataTable selectAll()
        {
            return ivideo.selectAll();
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public static DataTable selectKey(int id)
        {
            return ivideo.selectKey(id);
        }
        public static int GetIdCount()
        {
            return ivideo.GetId();
        }
        public static string GetEmail(int id)
        {
            return ivideo.GetEmail(id);
        }
        public static DataTable SelectAll(string email)
        {
            return ivideo.SelectAll(email);
        }
    }
}
