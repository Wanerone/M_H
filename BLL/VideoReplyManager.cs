using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class VideoReplyManager
    {
        private static IVideoReply ireply_video = DataAccess.CreateVideoReply();

        public static int addVideoReply(VideoReply reply)
        {
            return ireply_video.addVideoReply(reply);
        }
        public static DataTable SelectID(int id)
        {
            return ireply_video.SelectID(id);
        }
        public static SqlDataReader comReturn(int comID)
        {
            return ireply_video.comReturn(comID);
        }
        public static int Delete(int id)
        {
            return ireply_video.Delete(id);

        }
        public static DataTable SelectAll()
        {
            return ireply_video.SelectAll();
        }
    }
}
