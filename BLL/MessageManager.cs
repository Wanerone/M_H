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
  public static class MessageManager
    {
        private static IMessage imessage = DataAccess.CreateMessage();

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="message"></param>
        /// <returns>返回受影响行数</returns>
        public static int addMessage(Message message)
        {
            //if (string.IsNullOrEmpty(message.Title))
            //{
            //    throw new Exception("请填写私信标题！");
            //}
            //if (string.IsNullOrEmpty(message.Content))
            //{
            //    throw new Exception("请填写私信内容！");
            //}
            //if (string.IsNullOrEmpty(message.Receiver))
            //{
            //    throw new Exception("请选择接收对象");
            //}
            return imessage.addMessage(message);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="messages">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public static int addNumMessage(List<Message> messages)
        {
            return imessage.addNumMessage(messages);
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public static int deleteAll()
        {
            return imessage.deleteAll();
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public static int deleteKey(int id)
        {
            return imessage.deleteKey(id);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="message"></param>
        /// <returns>返回受影响行数</returns>
        public static int updateMessage(Message message)
        {
            return imessage.updateMessage(message);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public static DataTable selectAll()
        {
            return imessage.selectAll();
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public static DataTable selectKey(int id)
        {
            return imessage.selectKey(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public static DataTable selectKeyByUserID(int id)
        //{
        //    return imessage.selectKeyByUserID(id);
        //}

        public static DataTable selectKeyByUserID(string sid)
        {
            return imessage.selectKeyByUserID(sid);
        }

        //public static DataTable selectKeyByUser(string sid)
        //{
        //    return imessage.selectKeyByUser(sid);
        //}

        ///// <summary>
        ///// 批量删除私信
        ///// </summary>
        ///// <param name="messIDList"></param>
        ///// <returns></returns>
        //public static int DeleteByMessIDList(List<int> messIDList)
        //{

        //    int flag = 0;
        //    try
        //    {
        //        for (int i = 0; i < messIDList.Count; i++)
        //        {
        //            bool temp = true;
        //            DataTable dt = BLL.reviewManager.selectRevIDByMessID(messIDList[i]);
        //            if (dt != null && dt.Rows.Count != 0)
        //            {
        //                int rid = Convert.ToInt32(dt.Rows[0][0]);

        //                temp = BLL.reviewManager.deleteKey(rid) == 1 ? true : false;
        //            }
        //            if (temp && deleteKey(messIDList[i]) == 1)
        //            {
        //                flag++;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("删除失败");
        //    }

        //    return flag;
        //}

        public static int deleteByUser(string uID)
        {
            return imessage.deleteByUser(uID);
        }

    }
}
