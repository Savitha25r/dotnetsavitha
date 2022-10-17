using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    /*Create a simple Stationery application to add items and display added items 
     * using Generic List collections*/



    // method:1 add Stationery things here and console it will display the Stationery things and sort it and give as o/p
    class program4Stationery
    {
        public static void Main()
        {
            Console.WriteLine("-------- Method1: Display Stationery Added Items-------\n");
            program4Stationery st = new program4Stationery();
            st.Display();

            Console.WriteLine("---------Method2:Stationery Items--------");
            Stationary sta = new Stationary();
            string[] StationaryItem = new string[5];
            sta.Getitems(StationaryItem);
            Console.ReadLine();
        }

        public void Display()
        {
         
            List<string> itemlist = new List<string>();
           //using string adding statinory items
            itemlist.Add("Pencil");
            itemlist.Add("Pens");
            itemlist.Add("Eraser");
            itemlist.Add("Sharpner");
            itemlist.Add("Geometry box");

            
            foreach (string i in itemlist)
            {
                Console.WriteLine(i);
            }

            List<string> item = new List<string>();
            //using string adding statinory items
            Console.WriteLine("---------sorted statinery items-----------\n");
            item.Add("Pencil");
            item.Add("Pens");
            item.Add("Eraser");
            item.Add("Sharpner");
            item.Add("Geometry box");

            
            //sorting them
            itemlist.Sort();
            foreach (string s in itemlist)
            {
                Console.WriteLine(s);
            }

        }

        // method2: like user will take the input Stationary items from user and add stationary things and display

        class Stationary
        {

            public void Getitems(string[] StationaryItem)
            {

                for (int i = 0; i < StationaryItem.Length; i++)
                {
                    Console.WriteLine("Enter the Stationary item {0}: ", i + 1);      //enter the items from user what they need
                    StationaryItem[i] = Console.ReadLine();
                }
                List<string> item = new List<string>();
                for (int i = 0; i < StationaryItem.Length; i++)
                {
                    item.Add(StationaryItem[i]);
                }


                void Displayitem()                         //added items will display from the user
                {
                    int inc = 1;
                    foreach (var things in item)
                    {
                        Console.WriteLine("Added Stationary Item is{0}: {1}\t ", inc, things);
                        inc++;
                    }

                }
                Displayitem();
            }

        }

    }
}
