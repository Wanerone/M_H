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
  public  class PicReplyManager
    {
        private static IPicReply ireply_pic = DataAccess.CreatePicReply();

        public static int addVideoReply(PicReply reply)
        {
            return ireply_pic.addPicReply(reply);
        }
        public static DataTable SelectID(int id)
        {
            return ireply_pic.SelectID(id);
        }
        public static SqlDataReader comReturn(int comID)
        {
            return ireply_pic.comReturn(comID);
        }
        public static int Delete(int id)
        {
            return ireply_pic.Delete(id);

        }
        public static DataTable SelectAll()
        {
            return ireply_pic.SelectAll();
        }
    }
}
