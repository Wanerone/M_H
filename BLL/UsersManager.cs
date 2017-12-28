using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using DALFactory;
using System.Data.SqlClient;
using DAL;
using System.Web.UI;

namespace BLL
{
    public class UsersManager
    {
       
        private static IUsers istudent = DataAccess.CreateUsers();
        public static string SelectName(string email)
        {
            return istudent.SelectName(email);
        }
        public static string SelectEmail(string userName)
        {
            return istudent.SelectEmail(userName);
        }
        public static SqlDataReader GetEmail(string email)
        {
            return istudent.GetEmail(email);
        }
        public static SqlDataReader GetName(string name)
        {
            return istudent.GetName(name);
        }
        public static int AddUser(Users us)
        {
            return istudent.Insert(us);
        }
        public static SqlDataReader login(string email, string password)
        {
            return istudent.login(email, password);
        }
       
      /*  #region 【公有的静态方法部分】


        /// <summary>
        /// 删除的方法
        /// </summary>
        /// <param name="model">要删除的实体类对象</param>
        /// <returns>如果删除成功，则返回真。</returns>
        public static bool Delete(User model)
        {
            return SqlServerUser.Delete(model);
        }

        public static SqlDataReader SelectName(System.Web.UI.WebControls.TextBox userName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除的方法
        /// </summary>
        /// <param name="id">要删除的实体类对象的主键</param>
        /// <returns>如果删除成功，则返回真。</returns>
        public static bool Delete(int id)
        {

            //删除用户
            return SqlServerUser.Delete(id);
        }

        /// <summary>
        /// 更新的方法
        /// </summary>
        /// <param name="model">要更新的实体类对象</param>
        /// <returns>如果更新成功，则返回真。</returns>
        public static bool Modify(User model)
        {
            return SqlServerUser.Update(model);
        }

        /// <summary>
        /// 选择的方法
        /// </summary>
        /// <param name="id">要选择的实体类对象的主键</param>
        /// <returns>如果选择成功，则返回对象，否则返回null。</returns>
        public static User Select(int id)
        {
            return SqlServerUser.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// 选择的方法
        /// </summary>
        /// <returns>如果选择成功，则返回对象的泛型集合，否则返回null。</returns>
        public static List<UserIn> SelectAll()
        {
            return SqlServerUserIn.SelectAll();
        }

        #endregion*/
    }
}
