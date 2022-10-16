using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    /*Create a simple Stationery application to add items and display added items using Generic List collections*/
    class program4Stationery
    {
        public static void Main()
        {
            Console.WriteLine("-------- Display Stationery  Added Items-------\n");
            program4Stationery st = new program4Stationery();
            st.Display();
            Console.ReadLine();
        }

        public void Display()
        {
         
            List<string> strlist = new List<string>();
           //using string adding statinory items
            strlist.Add("Pencil");
            strlist.Add("Pens");
            strlist.Add("Eraser");
            strlist.Add("Sharpner");
            strlist.Add("Geometry box");

            
            foreach (string s in strlist)
            {
                Console.WriteLine(s);
            }

            List<string> str = new List<string>();
            //using string adding statinory items
            Console.WriteLine("---------sorted statinery items-----------\n");
            str.Add("Pencil");
            str.Add("fevistick");
            str.Add("Eraser");
            str.Add("Sharpner");
            str.Add("Geometry box");

            /*List<int> intlistid = new List<int>();
           Console.WriteLine("----------id number----------");//using int id number
           intlistid.Add(39);
           intlistid.Add(13);
           intlistid.Add(3);
           intlistid.Add(30);
           intlistid.Add(1);
           intlistid.Sort();
           foreach (int n in intlistid)
           {
               Console.WriteLine(n);
           }*/

            //sorting them
            strlist.Sort();
            foreach (string s in strlist)
            {
                Console.WriteLine(s);
            }

        }
    }
}
