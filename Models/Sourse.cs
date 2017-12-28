using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Sourse
    {
        private int sourse_id;
        private string Name;
        private DateTime Addtime;
        private string Website;
      
        public int sourse_ID
        {
            get { return this.sourse_id; }
            set { this.sourse_id = value; }
        }
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public DateTime addtime
        {
            get { return this.Addtime; }
            set { this.Addtime = value; }
        }
        public string website
        {
            get { return this.Website; }
            set { this.Website = value; }
        }
       
    }
}
