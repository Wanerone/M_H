using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
 public   interface IMessageReply
    {
        int addReply(MessageReply messageReply); //添加一条记录
        int addNumReply(List<MessageReply> messageReplys); //批量添加数据
        int deleteAll(); //删除全部数据
        int deleteKey(int id); //根据编号删除
        int updateReply(MessageReply messageReply); //更新一条数据
        DataTable selectAll();  //查询所有数据
        DataTable selectKey(int id); //按id查询
        DataTable selectRepIDByMessID(int mid);// 根据私信编号查询回复编号
        int deleteByUser(string uID);//用户删除
    }
}
