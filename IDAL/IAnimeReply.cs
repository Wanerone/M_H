using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IAnimeReply
    {
        int addreply(AnimeReply ar);
        DataTable selectID(int id);
        DataTable SelectID(int id);
        int Delete(int id);
        DataTable SelectAll();
        int CountReply();
    }
}
