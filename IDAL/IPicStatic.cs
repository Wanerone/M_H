using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDAL
{
   public interface IPicStatic
    {
        DataTable SelectAll();
        DataTable SelectID(int Pic_id);
        int UpdateVideoStatic(PictureStatic picstatic);
        int Insert(PictureStatic picstatic);
    }
}
