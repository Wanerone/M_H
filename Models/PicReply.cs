using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class PicReply
    {
        private int picReply_id;
        private int picComment_id;
        private string Email;
        private DateTime replytime;
        private string Content;

        public int PicReply_ID
        {
            get { return this.picReply_id; }
            set { this.picReply_id = value; }
        }
        public int PicComment_ID
        {
            get { return this.picComment_id; }
            set { this.picComment_id = value; }
        }

        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public DateTime ReplyTime
        {
            get { return this.replytime; }
            set { this.replytime = value; }
        }
        public string ReplyContent
        {
            get { return this.Content; }
            set { this.Content = value; }
        }
    }
}
