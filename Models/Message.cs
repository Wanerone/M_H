using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Message
    {
        int id;  //私信id
        string title;  //私信标题
        string content;  //私信内容
        string Time;  //发送时间
        string sender;   //发私信的人
        string receiver;  //私信接收者
        public int Message_ID
        {
            get { return id; }
            set { id = value; }
        }
       

        public string MessTitle
        {
            get { return title; }
            set { title = value; }
        }
        
        public string MessContent
        {
            get { return content; }
            set { content = value; }
        }
        

        public string MessTime
        {
            get { return Time; }
            set { Time = value; }
        }
        

        public string UserA
        {
            get { return sender; }
            set { sender = value; }
        }
        

        public string UserB
        {
            get { return receiver; }
            set { receiver = value; }
        }
    }
}
