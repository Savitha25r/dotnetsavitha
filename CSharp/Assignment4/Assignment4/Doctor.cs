using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    /*Create a Class called Doctor with RegnNo, Name, Feescharged as Private members.
       * Allow values to be set and also to display the same. */
    class Doctor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Doctor fee detail-----");
            detail ds = new detail();
            ds.Name = "Savitha";
            ds.RegNo = 116;
            ds.FeesCharged = 100;
            ds.Display();
            Console.Read();

        }
        class detail
    {
        private int regno;
        private string name;
        private int fees;
        public string Name  
        {
            get { return name; }
            set { name = value; }
        }

        public int RegNo    
        {
            get
            {
                return regno;
            }
            set
            {
                regno = value;
            }
        }

        public int FeesCharged 
        {
            get
            {
                return fees;
            }
            set
            {
                fees = value;
            }
        }


        public void Display()
        {            
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Register No :" + regno);
            Console.WriteLine("FeesCharged: " + fees);
        }
    }
   
    }

}