using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /*Create a class called Scholarship which has int Totalmarks and float fees as fields and a function Public float Merit(int m, float f) that takes Totalmarks and fees as an input.

If the given marks is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
If the given mark is >90, then calculate scholarship amount as 50% of the fees.
In all the cases return the Scholarship amount*/

    class scholarship
    {
        int Totalmarks;
        float fees;
        float ScholorshipAmount;

        static void Main(string[] args)
        {
            Console.WriteLine("--------scholarship Details--------");
            scholarship sp = new scholarship();
            Console.WriteLine("Enter Total Marks");
            sp.Totalmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fees amount");
            sp.fees = Convert.ToSingle(Console.ReadLine());
            sp.ScholorshipAmount = sp.Merit(sp.Totalmarks, sp.fees);
            Console.WriteLine("Scholorship Amount is " + sp.ScholorshipAmount);
            Console.Read();

        }
        public float Merit(int TotalMarks, float Fees)
        {
            if (TotalMarks >= 70 && TotalMarks <= 80)
            {
                return (20.0f / 100) * Fees;
            }
            else if (TotalMarks > 80 && TotalMarks <= 90)
            {
                return (30.0f / 100) * Fees;
            }
            else if (TotalMarks > 90)
            {
                return (50.0f / 100) * Fees;
            }
            return 0;
        }
    }
}
