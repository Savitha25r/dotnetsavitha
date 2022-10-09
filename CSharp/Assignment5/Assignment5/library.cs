using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace Assignment5
{
    /* Create a Console application with a Class called Program which has int TotalFare as Constant, 
      Name, Age.  Accept Name,
     Age from the user and call the CalculateConcession() function
     (Hint : Add required references)*/   //(add dll file here) and even classlibrary1
    class library
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------Ticket Booked Details-------");
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Concession concession = new Concession();      //dll class library created class concession we use here
            concession.CalculateConcession(age);
            Console.ReadLine();

        }
    }
}


