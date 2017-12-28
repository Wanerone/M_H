using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Video
    {
        private string Email;
        private int id;
        private string title;
        private string Url;
        private string img;
        private DateTime creattime;
        private string Jianjie;
        private string Category;
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }

        public int Vid_id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Vid_title
        {
            get { return this.title; }
            set { this.title = value; }
        }


        public string Vid_url
        {
            get { return this.Url; }
            set { this.Url = value; }
        }
        public string Vid_img
        {
            get { return this.img; }
            set { this.img = value; }
        }
        public DateTime Vid_creattime
        {
            get { return this.creattime; }
            set { this.creattime = value; }
        }
        public string Vid_jianjie
        {
            get { return this.Jianjie; }
            set { this.Jianjie = value; }
        }
        public string Vid_category
        {
            get { return this.Category; }
            set { this.Category = value; }
        }

    }
}
