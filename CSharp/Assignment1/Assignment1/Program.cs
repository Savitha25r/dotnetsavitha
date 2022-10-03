using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("*************** Program 1*************");

            Console.WriteLine("Enter the number to check both values are equal");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.result(num1, num2);
            Console.WriteLine("");

            Console.WriteLine("***************Program2 *************");
            Console.WriteLine("enter a number to check positive or negative");
            Example2 ex = new Example2();
            ex.PositiveOrNegative();
            Console.WriteLine("");

            Console.WriteLine("*********Program 3************");
            Example3 ex3 = new Example3();
            ex3.oper();

            Console.WriteLine("*********Program 4************");
            Example4 ex4 = new Example4();
            ex4.cal();


            Console.WriteLine("*********Program 5************");
            Example5 ex5 = new Example5();
            ex5.cel();

            Console.ReadKey();
        }
        public void result(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal ", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal ", num1, num2);
            }
        }



    }
    public class Example2
    {
        public int val1 = 0;
        public int val2 = Convert.ToInt32(Console.ReadLine());
        public void PositiveOrNegative()
        {
            if (val1 > val2)
            {
                Console.WriteLine($"the given number {val2} is Negative");
            }
            else
            {
                Console.WriteLine($"the given number {val2} is Positive");
            }
        }
    }


    //program3
    public class Example3
    {

        public void oper()
        {
            int x, y;
            char operation;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");

            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());


            if (operation == '+')
                Console.WriteLine("Excepted output: {0} + {1} = {2}", x, y, x + y);


            else if (operation == '-')
                Console.WriteLine("Excepted output: {0} - {1} = {2}", x, y, x - y);

            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("Excepted output: {0} * {1} = {2}", x, y, x * y);

            else if (operation == '/')
                Console.WriteLine("Excepted output: {0} / {1} = {2}", x, y, x / y);

            else
                Console.WriteLine("Wrong Character");

        }
    }

    }

//program4
public class Example4
{

    public void cal()
    {

        int csharp, html, sql, total;
        {
            Console.WriteLine("enter the csharp marks");
            csharp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the html marks");
            html = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the sql marks");
            sql = Convert.ToInt32(Console.ReadLine());
            total = csharp + html + sql;
            Console.WriteLine("The total marks is:{0}", total);
            {
                if (total < 49)
                    Console.WriteLine("The student is Fail");



                else if (total > 50)
                    Console.WriteLine("The student is pass");



            }
        }
            }

        }



            



//program5


public class Example5
{

    public void cel()
    {
        double celsius;
        double fahrenheit = 97;
        Console.WriteLine("Fahrenheit: " + fahrenheit);
        celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Celsius: " + celsius);
        
    }
}