using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class VideoStatic
    {
        private int video_id;
        private int readcount;
        private int upvote;
        private int Collection;
        

        public int Vid_id
        {
            get { return this.video_id; }
            set { this.video_id = value; }
        }
        public int readCount
        {
            get { return this.readcount; }
            set { this.readcount = value; }
        }

        public int upVote
        {
            get { return this.upvote; }
            set { this.upvote = value; }
        }
       
       public int collection
        {
            get { return this.Collection; }
            set { this.Collection = value; }
        }
    }
}
