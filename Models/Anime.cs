using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Anime
    {
        private int anime_id;
        private string link;
        private string Addtime;
        private string Content;
        private string name;
        private string image;
        private string Location;
        private string Label;

        public string label
        {
            set { this.Label = value; }
            get { return this.Label; }
        }

        public string location
        {
            set { this.Location = value; }
            get { return this.Location; }
        }

        public int anime_ID
        {
            get { return this.anime_id; }
            set { this.anime_id = value; }
        }
        public string anime_Link
        {
            get { return this.link; }
            set { this.link = value; }
        }
        
        public string addtime
        {
            get { return this.Addtime; }
            set { this.Addtime = value; }
        }
       
        
        public String jianjie
        {
            get { return this.Content; }
            set { this.Content = value; }

        }
        public String anime_Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public String anime_Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

    }
}
