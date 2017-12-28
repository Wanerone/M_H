using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ArticleReply
    {
        private int articleComment_id;
        private int articlereply_id;
        private DateTime replyTime;
        private String replyContent;
        private string Email;


        public int ArticleComment_id
        {
            get { return this.articleComment_id; }
            set { this.articleComment_id = value; }
        }
        public int ArticleReply_id
        {
            get { return this.articlereply_id; }
            set { this.articlereply_id = value; }
        }
        public DateTime ReplyTime
        {
            get { return this.replyTime; }
            set { this.replyTime = value; }
        }
        public String ReplyContent
        {
            get { return this.replyContent; }
            set { this.replyContent = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
    }
}
