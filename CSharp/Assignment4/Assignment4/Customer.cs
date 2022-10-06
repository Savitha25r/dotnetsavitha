using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /*Create a class called Customer with Customerid, Name, Age, Phone,City.
    * Write a constructor with no arguments and another constructor with all information.  
    * Write a method called DisplayCustomer(), 
    * which is called directly without any object. Also  include destructor */
    class Customer
    {

        int Customerid;
        string Name;
        int age;
        string Phone;
        string City;

        //customer
        static void Main(string[] args)
        {
            Console.WriteLine("--------Customer Details--------");
            Customer c1 = new Customer(11, "Savitha", 22, "9654321786", "Bangalore");
            Customer.DisplayCustomer(c1);
            Customer c2 = new Customer();
            GC.Collect();

            Console.ReadLine();
        }

        public Customer()
        {

        }
        public Customer(int Customerid, string Name, int age, string Phone, string City)
        {
            this.Customerid = Customerid;
            this.Name = Name;
            this.age = age;
            this.Phone = Phone;
            this.City = City;
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer Id Is: " + customer.Customerid);
            Console.WriteLine("Customer Name Is: " + customer.Name);
            Console.WriteLine("Customer age Is: " + customer.age);
            Console.WriteLine("Phone Number Is: " + customer.Phone);
            Console.WriteLine("City Is: " + customer.City);
        }

        ~Customer()
        {
            Console.WriteLine("savitha Destructor Called");
            Console.ReadLine();

        }
    }


}

    