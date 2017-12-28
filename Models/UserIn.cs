using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    [Serializable]
    public  class UserIn
    {
        #region 声明用户属性
        //用户邮箱
        public string email { get; set; }
        //用户名
        public string userName { get; set; }
        //用户头像
        public  string headimg{ get; set; }
        //用户性别
        public string sex { get; set; }
        //用户生日
        public string birthday { get; set; }
        //用户地址
        public string addr { get; set; }
        //个性签名
        public string perSign { get; set; }
        #endregion

        public UserIn()
        {

        }
    }
}
