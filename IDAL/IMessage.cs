using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace IDAL
{
  public  interface IMessage
    {
        int addMessage(Message message); //添加一条记录
        int addNumMessage(List<Message> messages); //批量添加数据
        int deleteAll(); //删除全部数据
        int deleteKey(int id); //根据编号删除
        int updateMessage(Message message); //更新一条数据
        DataTable selectAll();  //查询所有数据
        DataTable selectKey(int id); //按id查询
        //DataTable selectKeyByUserID(int id);// 查询某个用户的私信以及该私信的回复
        int deleteByUser(string uID);//用户自己查询删除
        DataTable selectKeyByUserID(string sid);

        //DataTable selectKeyByUser(string id);
    }
}
