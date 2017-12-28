using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Article
    {
        public string email
        {
            get;
            set;
        }
        public int Art_id
        {
            get;
            set;
        }
        public string Art_title
        {
            get;
            set;
        }
        public DateTime Art_creatTime
        {
            get;
            set;
        }
        public string Art_content
        {
            get;
            set;
        }
        public string Art_image
        {
            get;
            set;
        }
        public string Art_lable
        {
            get;
            set;
        }
    }
}
