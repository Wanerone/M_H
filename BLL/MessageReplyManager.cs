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
  public static class MessageReplyManager
    {
        private static IMessageReply ireview = DataAccess.CreateMessageReply();
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="review"></param>
        /// <returns>返回受影响行数</returns>
        public static int addReply(MessageReply review)
        {
            //if (string.IsNullOrEmpty(review.Content))
            //{
            //    throw new Exception("请输入回复内容！");
            //}

            return ireview.addReply(review);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="reviews">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public static int addNumReply(List<MessageReply> reviews)
        {
            return ireview.addNumReply(reviews);
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public static int deleteAll()
        {
            return ireview.deleteAll();
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public static int deleteKey(int id)
        {
            return ireview.deleteKey(id);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="review"></param>
        /// <returns>返回受影响行数</returns>
        public static int updateReply(MessageReply review)
        {
            return ireview.updateReply(review);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public static DataTable selectAll()
        {
            return ireview.selectAll();
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public static DataTable selectKey(int id)
        {
            return ireview.selectKey(id);
        }

        /// <summary>
        /// 根据私信编号查询回复编号
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public static DataTable selectRepIDByMessID(int mid)
        {
            return ireview.selectRepIDByMessID(mid);
        }

        public static int deleteByUser(string uID)
        {
            return ireview.deleteByUser(uID);
        }
    }
}
