using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class AnimeComment
    {
        private int Com_id;
        private int Anime_ID;
        private DateTime Time;
        private String Comment;
        private string Email;


        public int com_id
        {
            get { return this.Com_id; }
            set { this.Com_id = value; }
        }
        public int anime_ID
        {
            get { return this.Anime_ID; }
            set { this.Anime_ID = value; }
        }
        public DateTime time
        {
            get { return this.Time; }
            set { this.Time = value; }
        }
        public String comment
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
