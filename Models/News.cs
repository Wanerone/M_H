using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class News
    {
        private int News_id;
        private string title;
        private DateTime creattime;
        private string content;
        private string jianjie;
        private string image;
        public int News_ID
        {
            get { return this.News_id; }
            set { this.News_id = value; }
        }
        public string News_title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public DateTime News_creattime
        {
            get { return this.creattime; }
            set { this.creattime = value; }
        }
        public string News_content
        {
            get { return this.content; }
            set { this.content = value; }
        }
        public string News_jianjie
        {
            get { return this.jianjie; }
            set { this.jianjie = value; }
        }
        public string News_image
        {
            get { return this.image; }
            set { this.image = value; }
        }
      
    }
}
