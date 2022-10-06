using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /*Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty *Price
Pass the other information like SalesNo, Productno, Price,Qty and Dateof sale through constructor
call the show data method to display the values.
Hint : Use This pointer */

    class SaleDetails
    {
        static void Main(string[] args)
        {
            SaleDetails sd = new SaleDetails(10, 116, 15000f, "10/05/2022", 2);
            sd.Sales(sd.Qty, sd.Price);     //totalamount= quantiy*price = 2*15000
            sd.ShowData();
            Console.ReadLine();
        }

        int Saleno;
        int Productno;
        float Price;
        string dateofsale;
        int Qty;
        float TotalAmount;
        public SaleDetails(int Saleno, int Productno, float Price, string dateofsale, int Qty)
        {
            this.Saleno = Saleno;
            this.Productno = Productno;
            this.Price = Price;
            this.dateofsale = dateofsale;
            this.Qty = Qty;
        }
        public float Sales(int Quantity, float Price)
        {
            TotalAmount = Quantity * Price;
            return TotalAmount;
        }
        public void ShowData()
        {
            Console.WriteLine("--------Sales details--------");
            Console.WriteLine("Sales Number: " + Saleno);
            Console.WriteLine("Product Number: " + Productno);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Date of Sale: " + dateofsale);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmount);
        }
    }
}

