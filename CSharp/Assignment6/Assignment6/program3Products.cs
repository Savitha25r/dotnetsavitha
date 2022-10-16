using System;
using System.Collections.Generic;        //using collections
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    /* Create a Class called Products with Productid, Product Name, Price. 
       Accept 10 Products, sort  them based on the price,
       and display the sorted Products*/

    //Create a Class called Products with Productid, Product Name, Price.
    class program3Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }


        //function to create a list of product details
        public static void Main()
        {
            List<program3Products> prdlist = new List<program3Products>()
                    {
                        new program3Products{ProductId=104,  ProductName="Laptop",            Price=35000.0f},
                        new program3Products{ProductId=290,  ProductName="headset",           Price=1000.0f},
                        new program3Products{ProductId=870,  ProductName="Carromboardset",    Price=2499.0f},
                        new program3Products{ProductId=250,  ProductName="Spikeshoes",        Price=1368.0f},
                        new program3Products{ProductId=210,  ProductName="Hairstaightner",    Price=2799.0f},
                        new program3Products{ProductId=400,  ProductName="Makeupkit",         Price=999.0f},
                        new program3Products{ProductId=280,  ProductName="Iphone",            Price=189900.0f},
                        new program3Products{ProductId=100,  ProductName="RoyalEnfield",      Price=147910},
                        new program3Products{ProductId=600,  ProductName="Sarees",            Price=2000.0f},
                        new program3Products{ProductId=300,  ProductName="WashingMachine",    Price=37490.0f},
                   };

            Displayprd(prdlist);
            Console.Read();
        }

        public static void Displayprd(List<program3Products> products)
        {
            Console.WriteLine("---------Display Product list sorting through price ---------");
            var val = products.OrderBy(d => d.Price).ToList();      //immediate execution will happen we have used tolist and order by ascending order by price it will sort price from least to high

            foreach (var p in val)                //p is inherit implicit
            {

                //Console.WriteLine("id: {0} ", p.ProductId);
                //Console.WriteLine("name: {0} ", p.Product_Name);
                //Console.WriteLine("price: {0} ", p.Price);
                Console.WriteLine("name: {0}   \tid: {1}   \tprice: {2}    \t", p.ProductName, p.ProductId, p.Price);
            }
        }
    }

}
