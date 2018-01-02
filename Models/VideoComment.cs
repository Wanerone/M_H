using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class VideoComment
    {
        private int Comment_id;
        private int video_id;
        private string Email;
        private DateTime time;
        private string Content;
        public int com_id
        {
            get { return this.Comment_id; }
            set { this.Comment_id = value; }
        }
        public int Vid_id
        {
            get { return this.video_id; }
            set { this.video_id = value; }
        }
        public DateTime ComTime
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public String ComContent
        {
            get { return this.Content; }
            set { this.Content = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
    }
}
