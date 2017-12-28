using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
 public   class Goods
    {
        public int Goods_ID
        {
            get;
            set;
        }
        public string Goods_Name
        {
            get;
            set;
        }
       
        public string Goods_Image
        {
            get;
            set;
        }
        public string Goods_Description
        {
            get;
            set;
        }
        public DateTime AddTime
        {
            get;
            set;
        }
        public double Goods_Price
        {
            get;
            set;

        }
        public int Goods_Count
        {
            get;
            set;

        }
      
    }
}
