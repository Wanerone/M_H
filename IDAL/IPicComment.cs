using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface IPicComment
    {
        int addcomment_picture(PicComment picturecomment);
        DataTable SelectAll();
        DataTable SelectcoutID(int PicComment_id);
        DataTable SelectTop(int top);
        DataTable SelectID(int id);
        int Delete(int id);
        int CountComment();
    }
}
