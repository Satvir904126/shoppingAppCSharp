using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_App
{
   abstract class Merchandise
    {
        public int Price { get; set; }
        public string Item { get; set; }
     public int SerialNumber { get; set; }
        public Merchandise(int price,string item,int serialNumber)
        {
            Price = price;
            Item = item;
            SerialNumber = serialNumber;
        }

    }
}
