using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class AnimeReply
    {
        private int Com_id;
        private int Reply_id;
        private DateTime Time;
        private String Comment;
        private string Email;


        public int com_id
        {
            get { return this.Com_id; }
            set { this.Com_id = value; }
        }
        public int reply_id
        {
            get { return this.Reply_id; }
            set { this.Reply_id = value; }
        }
        public DateTime reply_time
        {
            get { return this.Time; }
            set { this.Time = value; }
        }
        public String reply_content
        {
            get { return this.Comment; }
            set { this.Comment = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
    }
}
