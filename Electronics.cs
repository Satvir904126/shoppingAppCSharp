using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_App
{
    class Electronics:Merchandise
    {
        public Electronics(int price, string item, int serialNumber) : base(price, item, serialNumber)
        {

        }

    }
}
