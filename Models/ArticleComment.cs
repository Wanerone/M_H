using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ArticleComment
    {
        private int articleComment_id;
        private int article_id;
        private DateTime comTime;
        private String comContent;
        private string Email;


        public int ArticleComment_id
        {
            get { return this.articleComment_id; }
            set { this.articleComment_id= value; }
        }
        public int Art_id
        {
            get { return this.article_id; }
            set { this.article_id = value; }
        }
        public DateTime ComTime
        {
            get { return this.comTime; }
            set { this.comTime = value; }
        }
        public String ComContent
        {
            get { return this.comContent; }
            set { this.comContent = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
    }
}
