using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class PictureStatic
    {
        private int pic_id;
        private int readcount;
        private int upvote;
        

        public int Pic_id
        {
            get { return this.pic_id; }
            set { this.pic_id = value; }
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

    }
}
