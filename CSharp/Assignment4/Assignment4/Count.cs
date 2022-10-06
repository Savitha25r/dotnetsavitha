using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /*count occurance of times 
     Create a Program to count the no. of occurrences of a letter in a given string (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
Hint : Accept a string and also the letter to be counted
Strengthning OOPS:*/

    class Count
    {
        static void Main(string[] args)

        {
            Console.WriteLine("--------Program to count the no. of occurrences of a letter in a given string--------");
            Console.WriteLine("Enter a String value ");
            string value = Console.ReadLine();


        Console.WriteLine("Enter a letter to check the occurance ");
            char letter = Convert.ToChar(Console.ReadLine());

        int cnt = 0;
        Count.Occurance(value, letter, cnt);
            Console.ReadLine();
    }
        public static void Occurance(string value, char letter, int cnt)
        {
            for (int j = 0; j < value.Length; j++)
            {
                if (value[j] == letter)
                {
                    cnt++;
                }
            }
            if (cnt > 0)
            {
                Console.WriteLine("the given letter {0} is occured for {1} times", letter, cnt);
            }
            else
            {
                Console.WriteLine("the given letter is not repeated");
            }
        }
    }

}

