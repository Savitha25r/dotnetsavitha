using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test
{
    /*Write a class Box that has Length and breadth as its members.
     * Write a function that adds 2 box objects and stores in the 3rd.
     * Create a Test class to execute the above.
*/
    class Box
    {

        public int length { get; set; }
        public int breadth { get; set; }
        public static Box operator +(Box obj1, Box obj2)
        {
            Box obj = new Box();
            obj.length = obj1.length + obj2.length;
            obj.breadth = obj1.breadth + obj2.breadth;
            return obj;
        }

        
        class Testclass
        {
            static void Main()
            {
                Box r1 = new Box();
                Box r2 = new Box();
                r1.length = 51; r1.breadth = 41;
                r2.length = 98; r2.breadth = 50;
                Box thirdr3 = r1 + r2;
                Console.WriteLine("The Total Length and Breadth is {0} {1}", thirdr3.length, thirdr3.breadth);
                
                Console.ReadLine();
            }
        }
    }
}