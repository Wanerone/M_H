using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class Activity
    {
        private int Activity_id;
        private string Email;
        private int userscount;
        private DateTime begintime;
        private DateTime endtime;
        private string place;
        private string content;
        private string name;
        private string image;
        public int Activity_ID
        {
            get { return this.Activity_id; }
            set { this.Activity_id = value; }
        }
        public string  email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public int UsersCount
        {
            get { return this.userscount; }
            set { this.userscount = value; }
        }
        public DateTime ActBeginTime
        {
            get { return this.begintime; }
            set { this.begintime = value; }
        }
        public DateTime ActEndtime
        {
            get { return this.endtime; }
            set { this.endtime = value; }
        }
        public String ActPlace
        {
            get { return this.place; }
            set { this.place = value; }
        }
        public String ActContent
        {
            get { return this.content; }
            set { this.content = value; }

        }
        public String ActName
        {
            get { return this.name; }
            set { this.name = value; }
        }
      
       
        public String ActImage
        {
            get { return this.image; }
            set { this.image = value; }
        }
       
       
       
    }
}
