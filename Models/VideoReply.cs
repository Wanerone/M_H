using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
 public   class VideoReply
    {
        private int videoReply_id;
        private int videoComment_id;
        private string Email;
        private DateTime replytime;
        private string Content;

        public int VideoReply_ID
        {
            get { return this.videoReply_id; }
            set { this.videoReply_id = value; }
        }
        public int VideoComment_ID
        {
            get { return this.videoComment_id; }
            set { this.videoComment_id = value; }
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
