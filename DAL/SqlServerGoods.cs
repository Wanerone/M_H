using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
  public  class SqlServerGoods:IGoods
    {
        ///// <summary>
        ///// 参数赋值
        ///// </summary>
        ///// <param name="video"></param>
        ///// <returns>返回参数数组</returns>
        //private SqlParameter[] AssignParameter(Goods goods)
        //{
        //    SqlParameter[] sp = new SqlParameter[]{

                
        //        new SqlParameter("@Goods_ID",goods.Goods_ID),
        //        new SqlParameter("@Goods_Name",goods.Goods_Name),
        //        new SqlParameter("@Goods_Price",goods.Goods_Price),
        //        new SqlParameter("@Goods_Description",goods.Goods_Description),
        //        new SqlParameter("@Goods_Count",goods.Goods_Count),
        //        new SqlParameter("@Goods_Image",goods.Goods_Image),
        //        new SqlParameter("@AddTime",goods.AddTime),
        //    };

        //    return sp;
        //}
        //public int insert(Goods goods)
        //{
        //    string sql = "insert into Goods(Goods_ID,Goods_Name,Goods_Price,Goods_Description,Goods_Count,Goods_Image,AddTime) values( @Goods_ID,@Goods_Name,@Goods_Price,@Goods_Description,@Goods_Count,@Goods_Image,@AddTime)";

        //    return SQLHelper.GetExcuteNonQuery(sql, AssignParameter(goods));
        //}
        public DataTable SelectGoods_id(int Goods_id)
        {
            string sql = "Select * From Goods where Goods_id=@Goods_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Goods_id",Goods_id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectGoodsTop(int top)
        {
            string sql = "select  top " + top + " * from Goods";

            return SQLHelper.GetFillData(sql);
        }
       
        public DataTable SelectAll()
        {
            string sql = "select * from Goods order by AddTime desc";
            return SQLHelper.GetFillData(sql);
        }
        
        public int Insert(Goods goods)
        {
            string sql = "insert into Goods (Goods_Name,Goods_Description,AddTime,Goods_Price,Goods_Count) values(@GoodsName,@Goods_Description,@AddTime,@Goods_Price,@Goods_Count)";
            SqlParameter[] sp = new SqlParameter[]
            {
                      new SqlParameter("@GoodsName",goods.Goods_Name),
                      new SqlParameter("@Goods_Description",goods.Goods_Description),
                      new SqlParameter("@AddTime",goods.AddTime),
                      new SqlParameter("@Goods_Price",goods.Goods_Price),
                      new SqlParameter("@Goods_Count",goods.Goods_Count),
                     
            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        
        public int Delete(int id)
        {
            string sql = "delete from Goods where Goods_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }
        public int UpdateGoods(Goods goods)
        {
            string sql = "Update Goods set Goods_Image=@Goods_Image,Goods_Description=@Goods_Description where Goods_ID=@Goods_ID";
            SqlParameter[] sp = new SqlParameter[]
                                                {
                                                 new SqlParameter("@Goods_ID",goods.Goods_ID),

                                                 new SqlParameter("@Goods_Image",goods.Goods_Image),
                                                 new SqlParameter("@Goods_Description",goods.Goods_Description),
                                                 
                                                 };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectID(int Goods_id)
        {
            string sql = "select  * from Goods where Goods_ID=@Goods_ID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Goods_ID",Goods_id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public int GetId()
        {
            string sql = "select count(Goods_ID) from Goods ";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
    }
}

