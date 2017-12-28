using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDAL
{
 public interface IPicture
    {
        DataTable SelectAll();
        DataTable SelectID(int Pic_id);
        DataTable SelectPicTop(int top);
        int Insert(Picture picture);
        int addNumPicture(List<Picture> pictures);
        int DeleteID(int id);
        int deleteAll();
        int UpdatePic(Picture picture);
        
    }
}
