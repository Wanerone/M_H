using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
  public  class PicCommentManager
    {
        private static IPicComment icomment_pic = DataAccess.CreatePicComment();
        public static DataTable SelectAll()
        {
            return icomment_pic.SelectAll();
        }
        public static DataTable SelectID(int id)
        {
            return icomment_pic.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return icomment_pic.SelectTop(top);
        }
        public static int addcomment_picture(PicComment comment_pic)
        {
            return icomment_pic.addcomment_picture(comment_pic);
        }
        public static DataTable SelectcoutID(int id)
        {
            return icomment_pic.SelectID(id);
        }
        public static int Delete(int id)
        {
            return icomment_pic.Delete(id);
        }
        public static int CountComment()
        {
            return icomment_pic.CountComment();
        }
    }
}
