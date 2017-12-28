using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IDAL
{
 public interface IVideoReply
    {
        int addVideoReply(VideoReply reply);
        SqlDataReader comReturn(int comID);
        DataTable SelectID(int id);
        int Delete(int id);
        DataTable SelectAll();
    }
}
