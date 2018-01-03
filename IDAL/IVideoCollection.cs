using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IVideoCollection
    {
        string GetState(string email, int id);
        int UpdateTrue(string email, int id);
        int UpdateFalse(string email, int id);
        int add(VideoCollection art);
    }
}
