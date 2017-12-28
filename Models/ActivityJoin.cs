using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class ActivityJoin
    {
        private int JoinActivity_id;
        private int activity_id;
        private string Email;
        private DateTime jointime;

        public int ActivityJoin_ID
        {
            get { return this.JoinActivity_id; }
            set { this.JoinActivity_id = value; }
        }
        public int Activity_ID
        {
            get { return this.activity_id; }
            set { this.activity_id = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public DateTime JoinTime
        {
            get { return this.jointime; }
            set { this.jointime = value; }
        }
    }
}
