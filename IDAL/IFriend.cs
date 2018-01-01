using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
 public   interface IFriend
    {
        int addFriend(Friend f);
        string GetUserB(string UserA);
        int count();
        int deleteFriend(string UserA, string UserB);
      //  int Getid();
    }
}
