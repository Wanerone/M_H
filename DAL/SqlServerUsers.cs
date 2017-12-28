using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using System.Configuration;
using IDAL;

namespace DAL
{
    public class SqlServerUsers:IUsers
    {

        public  SqlDataReader login(string email, string password)
        {
            string sql = "select * from Users where email=@email and password=@password";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email),
                new SqlParameter("@password",password)
            };
            return SQLHelper.GetDataReader(sql, sp);
        }
        public string SelectName(string email)
        {
            string sql = "select userName from Users where email=@email";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        public string SelectEmail(string userName)
        {
            string sql = "select email from Users where userName=@userName";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@userName",userName)
            };
            return SQLHelper.ExecuteScalar<string>(sql, sp);
        }
        public  SqlDataReader GetName(string userName)
        {
            string sql = "select * from Users where userName=@userName";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@userName",userName)
            };
            return SQLHelper.GetDataReader(sql, sp);
        }
        public  SqlDataReader GetEmail(string email)
        {
            string sql = "select * from Users where email=@email";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",email)
            };
            return SQLHelper.GetDataReader(sql, sp);
        }

        public int Insert(Users us)
        {
            string sql = "insert into Users values(@email,@userName,@password,@question,@answer,@creattime)";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@email",us.email),
                new SqlParameter("@username",us.userName),
                new SqlParameter("@password",us.password),
                new SqlParameter("@question",us.question),
                new SqlParameter("@answer",us.answer),
                new SqlParameter("@creattime",us.creattime),
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

    /*    #region 【公有的静态方法部分】

        /// <summary>
        /// 删除的方法
        /// </summary>
        /// <param name="model">要删除的实体类对象</param>
        /// <returns>如果删除成功，则返回真。</returns>
        public static bool Delete(User model)
        {
            string sql = "Delete From [User] Where [email] = @email";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",model.email)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp) > 0 ? true : false;
        }

        /// <summary>
        /// 删除的方法
        /// </summary>
        /// <param name="id">要删除的实体类对象的主键</param>
        /// <returns>如果删除成功，则返回真。</returns>
        public static bool Delete(int id)
        {
            string sql = "Delete From [User] Where [email] = @email";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",id)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp) > 0 ? true : false;
        }

        /// <summary>
        /// 更新的方法
        /// </summary>
        /// <param name="model">要更新的实体类对象</param>
        /// <returns>如果更新成功，则返回真。</returns>
        public static bool Update(User model)
        {
            string sql = "Update [User] Set [password] = @password Where [email] = @emial";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",model.email),
                new SqlParameter("@password",model.password)
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp) > 0 ? true : false;
        }

        /// <summary>
        /// 选择的方法
        /// </summary>
        /// <param name="id">要选择的实体类对象的主键</param>
        /// <returns>如果选择成功，则返回对象，否则返回null。</returns>
        public static User SelectByPrimaryKey(int id)
        {
            string sql = "Select * From [User] Where [email] = @email";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@email",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return CreateInstance(dt.Rows[0]);
            }
        }

        /// <summary>
        /// 选择的方法(选择全部)
        /// </summary>
        /// <returns>如果选择成功，则返回对象的泛型集合，否则返回null。</returns>
        public static List<User> SelectAll()
        {
            string sql = "Select * From [User]";
            DataTable dt = SQLHelper.GetFillData(sql);
            return GetList(dt);
        }

        #endregion

        #region 【私有的静态方法部分】
        /// <summary>
        /// 创建实体类对象的方法
        /// </summary>
        /// <param name="dr">包含实体类数据的数据行对象</param>
        /// <returns>返回实体类的对象或空</returns>
        private static User CreateInstance(DataRow dr)
        {
            User model = new User();
            model.email= dr["email"].ToString();
            model.password = dr["password"].ToString();
            return model;
        }

        /// <summary>
        /// 创建实体类对象集合的方法
        /// </summary>
        /// <param name="dt">包含实体类数据的数据表对象</param>
        /// <returns>返回实体类的对象集合或空</returns>
        private static List<User> GetList(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                List<User> list = new List<User>();
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(CreateInstance(dr));
                }
                return list;
            }
        }


        public string GetName(User u)
        {
            throw new NotImplementedException();
        }
        #endregion*/

    }
}
