using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
public  class MessageReply
    {
        int id;   //回复id（主键）
        int messageID;  //私信标题（外键）
        string content;  //回复内容
        DateTime replyTime;  //回复时间
        string reviewer;  //回复者
        string receiver;  //回复接收者
        public int MessageReply_ID
        {
            get { return id; }
            set { id = value; }
        }
      

        public int Message_ID
        {
            get { return messageID; }
            set { messageID = value; }
        }
        

        public string ReplyContent
        {
            get { return content; }
            set { content = value; }
        }
       

        public DateTime ReplyTime
        {
            get { return replyTime; }
            set { replyTime = value; }
        }
        

        public string UserA
        {
            get { return reviewer; }
            set { reviewer = value; }
        }
      

        public string UserB
        {
            get { return receiver; }
            set { receiver = value; }
        }
    }
}
