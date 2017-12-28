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
  public  class SqlServerMessageReply:IMessageReply
    {
        /// <summary>
        /// 参数赋值
        /// </summary>
        /// <param name="review"></param>
        /// <returns>返回参数数组</returns>
        private SqlParameter[] AssignParameter(MessageReply messageReply)
        {
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",messageReply.MessageReply_ID),
                new SqlParameter("@messID",messageReply.Message_ID),
                new SqlParameter("@content",messageReply.ReplyContent),
                new SqlParameter("@time",messageReply.ReplyTime),
                new SqlParameter("@reviewer",messageReply.UserA),
                new SqlParameter("@receiver",messageReply.UserB)
            };

            return sp;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="review"></param>
        /// <returns>返回受影响行数</returns>
        public int addReply(MessageReply messageReply)
        {
            string sql = "insert into MessageReply(Message_ID,ReplyContent,UserA,UserB) values(@messID,@content,@reviewer,@receiver)";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(messageReply));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="messageReplys">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public int addNumReply(List<MessageReply> messageReplys)
        {
            int sum = 0;
            foreach (MessageReply item in messageReplys)
            {
                sum += addReply(item);
            }

            return sum;
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public int deleteAll()
        {
            string sql = "truncate table MessageReply";

            return SQLHelper.GetExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public int deleteKey(int id)
        {
            string sql = "delete from MessageReply where MessageReply_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };

            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        /// <summary>
        /// 根据用户名删除
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public int deleteByUser(string uID)
        {
            string sql = "delete from MessageReply where UserA=@id or UserB=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",uID)
            };

            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="messageReply"></param>
        /// <returns>返回受影响行数</returns>
        public int updateReply(MessageReply messageReply)
        {
            string sql = "update MessageReply set Message_ID=@messID,ReplyContent=@content,ReplyTime=@time,UserA=@reviewer,UserB=@receiver where MessageReply_ID=@id";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(messageReply));
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public DataTable selectAll()
        {
            string sql = "select * from MessageReply";

            return SQLHelper.GetFillData(sql);
        }

        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public DataTable selectKey(int id)
        {
            string sql = "select * from MessageReply where MessageReply_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };

            return SQLHelper.GetFillData(sql, sp);
        }

        /// <summary>
        /// 根据私信编号查询回复编号
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public DataTable selectRepIDByMessID(int mid)
        {
            string sql = "select MessageReply_ID from MessageReply where Message_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",mid)
            };

            return SQLHelper.GetFillData(sql, sp);
        }
    }
}
