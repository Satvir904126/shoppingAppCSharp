using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_App
{
    static class Store
    {
        static int totalPrice=0;

        public static List<Merchandise> forSale = new List<Merchandise>()
        {
            new Food(33, "Chicken", 01),
            new Food(222, "Bananas", 02),
            new Food(313, "Fruits", 03),
            new Food(313, "Samosa", 04),
            new Food(313, "Butter", 05),
            new Clothing(444,"Jeans",06),
            new Clothing(123,"Shirt",07),
            new Clothing(567,"T Shirt",08),
   new Clothing(234,"Jackit",09),
   new Clothing(214,"Snow Jackit",10),
   new Electronics(14,"Charger",11),
   new Electronics(24,"Wires",12),
   new Electronics(10,"Lapto Charger",13),
   new Electronics(30,"Back Cover",14),
   new Electronics(43,"Tape",15),

        };

        public static List<Merchandise> shoppingCart = new List<Merchandise>();

    }
}
