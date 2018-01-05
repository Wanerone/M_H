using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
 public   class FriendManager
    {
        private static IFriend ifriend = DataAccess.CreateFriend();
        public static int addFriend(Friend f)
        {
            return ifriend.addFriend(f);
        }
        public static string GetUserB(string UserA)
        {
            return ifriend.GetUserB(UserA);
        }
        public static int count(string UserB)
        {
            return ifriend.count(UserB);
        }
        public static int deleteFriend(string UserA, string UserB)
        {
            return ifriend.deleteFriend(UserA, UserB);
        }
        public static object Getid(string UserA, string UserB)
        {
            return ifriend.Getid(UserA, UserB);
        }
    }
}
