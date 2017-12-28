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
 public   class SqlServerMessage:IMessage
    {
        /// <summary>
        /// 参数赋值
        /// </summary>
        /// <param name="message"></param>
        /// <returns>返回参数数组</returns>
        private SqlParameter[] AssignParameter(Message message)
        {
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",message.Message_ID),
                new SqlParameter("@title",message.MessTitle),
                new SqlParameter("@content",message.MessContent),
                new SqlParameter("@time",message.MessTime),
                new SqlParameter("@sender",message.UserA),
                new SqlParameter("@receiver",message.UserB)
            };

            return sp;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="message"></param>
        /// <returns>返回受影响行数</returns>
        public int addMessage(Message message)
        {
            string sql = "insert into Message(MessTitle,MessContent,MessTime,UserA,UserB) values(@title,@content,@time,@sender,@receiver)";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(message));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="messages">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public int addNumMessage(List<Message> messages)
        {
            int sum = 0;
            foreach (Message item in messages)
            {
                sum += addMessage(item);
            }

            return sum;
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public int deleteAll()
        {
            string sql = "truncate table Message";

            return SQLHelper.GetExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响行数</returns>
        public int deleteKey(int id)
        {
            string sql = "delete from Message where Message_ID=@id";
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
            string sql = "delete from Message where UserA=@uID or UserB=@uID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@uID",uID)
            };

            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="message"></param>
        /// <returns>返回受影响行数</returns>
        public int updateMessage(Message message)
        {
            string sql = "update Message set MessTitle=@title,MessContent=@content,MessTime=@time,UserA=@sender,UserB=@receiver where Message_ID=@id";

            return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(message));
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public DataTable selectAll()
        {
            string sql = "select * from Message";

            return SQLHelper.GetFillData(sql);
        }

        /// <summary>
        /// 按主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回查询结果</returns>
        public DataTable selectKey(int id)
        {
            string sql = "select * from Message where Message_ID=@id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",id)
            };

            return SQLHelper.GetFillData(sql, sp);
        }
       

       
        public DataTable selectKeyByUserID(string sid)
        {
            string sql = "select * from Message  where Message.UserB=@id order by Message.MessTime desc";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@id",sid)
            };
            return SQLHelper.GetFillData(sql, sp);
        }

        //public DataTable selectKeyByUser(string sid)
        //{
        //    string sql = "select Message.*,Review.revContent,Review.revDate,Review.revID,Review.reviewer from Message left join Review on((Message.sender=@id or Message.receiver=@id) ) order by Review.revDate desc,Message.sendDate desc";
        //    SqlParameter[] sp = new SqlParameter[]{
        //        new SqlParameter("@id",sid)
        //    };
        //    return SQLHelper.GetFillData(sql, sp);
        //}


        
        //public DataTable selectKeyByUserID(int id)
        //{
        //    string sql = "select Message.*,Review.revContent,Review.revDate,Review.revID,Review.reviewer from Message  left join Review on(Message.messID=Review.messID and (Message.sender=@id or Message.receiver=@id) ) order by Review.revDate desc,Message.sendDate desc";
        //    SqlParameter[] sp = new SqlParameter[]{
        //        new SqlParameter("@id",id)
        //    };
        //    return SQLHelper.GetFillData(sql, sp);
        //}
    }
}
