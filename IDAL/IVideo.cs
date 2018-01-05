using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IVideo
    {
        int addVideo(Video video);
        int addNumVideo(List<Video> videoes);
        int deleteAll();
        int deleteKey(int id);
        int updateVideo(Video video);
        DataTable selectAll();
        DataTable SelectAll(string email);
        DataTable selectKey(int id);
        int GetId();
        string GetEmail(int id);
        DataTable SelectTop(int top);
        DataTable SelectLike(string like);
        int CountLike(string like);
        int countID(string email);
    }
}
