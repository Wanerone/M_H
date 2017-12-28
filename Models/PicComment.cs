using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class PicComment
    {
        private int Comment_id;
        private int picture_id;
        private string Email;
        private DateTime time;
        private string Content;

        public int PicComment_ID
        {
            get { return this.Comment_id; }
            set { this.Comment_id = value; }
        }
        public int Pic_ID
        {
            get { return this.picture_id; }
            set { this.picture_id = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
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
       
    }
}
