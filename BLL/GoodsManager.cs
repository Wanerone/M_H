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
 public   class GoodsManager
    {
        private static IGoods igoods = DataAccess.CreateGoods();
        public static DataTable SelectGoods_id(int Goods_id)
        {
            return igoods.SelectGoods_id(Goods_id);
        }
        public static DataTable SelectGoodsTop(int top)
        {
            return igoods.SelectGoodsTop(top);
        }
        
      
        public static int Insert(Goods goods)
        {
            return igoods.Insert(goods);
        }
       
        public static int Delete(int id)
        {
            return igoods.Delete(id);
        }
        public static int UpdateGoods(Goods goods)
        {
            return igoods.UpdateGoods(goods);
        }

        public static int GetIdCount()
        {
            return igoods.GetId();
        }

        public static DataTable SelectAll()
        {
            return igoods.SelectAll();
        }
        public static DataTable SelectID(int id)
        {
            return igoods.SelectID(id);
        }
    }
}
