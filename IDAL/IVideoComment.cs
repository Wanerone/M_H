using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface IVideoComment
    {
        int addcomment_video(VideoComment videocomment);
        DataTable SelectAll();
        DataTable SelectcoutID(int com_id);
        DataTable SelectTop(int top);
        DataTable SelectID(int id);
        int Delete(int id);
        int CountComment();
        int CountComment(int id);

    }
}
