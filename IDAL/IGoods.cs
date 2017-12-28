using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface IGoods
    {
        DataTable SelectGoods_id(int Goods_id);
        DataTable SelectGoodsTop(int top);
        DataTable SelectAll();
        //DataTable SelectID(int id);
        int Insert(Goods goods);
        int Delete(int id);
        int UpdateGoods(Goods goods);
        DataTable SelectID(int Goods_id);
        int GetId();
    }
}
