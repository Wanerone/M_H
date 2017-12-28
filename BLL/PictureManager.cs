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
    public class PictureManager
    {
        private static IPicture ipicture = DataAccess.CreatePicture();

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="picture"></param>
        /// <returns>返回受影响行数</returns>
        public static int insert(Picture picture)
        {
            return ipicture.Insert(picture);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="pictures">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public static int addNumPicture(List<Picture> pictures)
        {
            return ipicture.addNumPicture(pictures);
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public static int deleteAll()
        {
            return ipicture.deleteAll();
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public static int DeleteID(int id)
        {
            return ipicture.DeleteID(id);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="picture"></param>
        /// <returns>返回受影响行数</returns>
        public static int UpdatePic(Picture picture)
        {
            return ipicture.UpdatePic(picture);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public static DataTable SelectAll()
        {
            return ipicture.SelectAll();
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public static DataTable SelectID(int id)
        {
            return ipicture.SelectID(id);
        }
    
}
}