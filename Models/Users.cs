using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class Users
    {
        #region 声明用户属性
        //用户邮箱
        public string email { get; set; }
        //用户名
        public string userName { get; set; }
        //用户密码
        public string password { get; set; }
        //密保问题
        public string question { get; set; }
        //密保答案
        public string answer { get; set; }
        //创建时间
        public DateTime creattime { get; set; }
        #endregion

        public Users()
        {

        }
    }
}
