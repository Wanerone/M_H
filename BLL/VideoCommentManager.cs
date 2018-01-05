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
 public   class VideoCommentManager
    {
        private static IVideoComment icomment_video = DataAccess.CreateVideoComment();
        public static DataTable SelectAll()
        {
            return icomment_video.SelectAll();
        }
        public static DataTable SelectID(int id)
        {
            return icomment_video.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return icomment_video.SelectTop(top);
        }
        public static int addcomment_video(VideoComment comment_video)
        {
            return icomment_video.addcomment_video(comment_video);
        }
        public static DataTable SelectcoutID(int id)
        {
            return icomment_video.SelectID(id);
        }
        public static int Delete(int id)
        {
            return icomment_video.Delete(id);
        }
        public static int CountComment()
        {
            return icomment_video.CountComment();
        }
        public static int CountComment(int id)
        {
            return icomment_video.CountComment(id);
        }
    }
}
