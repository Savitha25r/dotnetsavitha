﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test
{
    /*1. Write a program to find the Sum and the Average points scored by the teams in the IPL.
     * Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches)
     * that takes no.of matches as input and accepts that many scores 
    from the user.The function should then display the Average and Sum of the scores.*/

   // using collection
    class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of match: ");        //how many match played enter
            int match = Convert.ToInt32(Console.ReadLine());


            Cricket.Pointscalculation(match);       
            Console.Read();
        }
    }


    class Cricket
    {

        Cricket c = new Cricket();
        public static List<int> Pointscalculation(int no_of_matches)             //points calculation
        {
            int avg = 0;
            int total = 0;


            List<int> score = new List<int>();

            for (int i = 0; i < no_of_matches; i++)        
            {
                Console.WriteLine("Enter the score {0}: ", i + 1);
                int marks = Convert.ToInt32(Console.ReadLine());
                score.Add(marks);

            }

            foreach (int s in score)
            {
                total += s;
            }
        
             void CalcAvg(int Total, int match)
            {
            
            Console.WriteLine("The Total score is: " + total);
                avg = total / no_of_matches;
                Console.WriteLine("The avg score of this team is: " + avg);
            }

            CalcAvg(total, no_of_matches);
            return score.ToList(); 
        }

    }
}