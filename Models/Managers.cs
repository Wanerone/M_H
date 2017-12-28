using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class Managers
    {
        private int Manages_id;
        private string name;
        private string passWord;

        public int Managers_id
        {
            get { return this.Manages_id; }
            set { this.Manages_id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Password
        {
            get { return this.passWord; }
            set { this.passWord = value; }
        }
    }
}
