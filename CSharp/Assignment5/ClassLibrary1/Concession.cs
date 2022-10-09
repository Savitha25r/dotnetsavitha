using System;

namespace ClassLibrary1
{

        /*Create a class library Project called Concession. Write a method called CalculateConcession(int age)
         that takes age as an input and calculates concession for travel as below:
         If age<=5 then “Little Champs- Free Ticket” should be displayed
         If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and 
         Display “ Senior Citizen” + Calculated Fare
         Else “Print Ticket Booked” + Fare.*/
    public class Concession
    {
        public void CalculateConcession(int age)
        {
            int totalfare = 500;       //totalfare = 500;  
            float ConcessionAmount;
            float CalculatedAmount;
            if (age <= 5) //free ticket
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)   //senior citizen
            {
                ConcessionAmount = Convert.ToInt32(0.3f * totalfare); //If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-)
                CalculatedAmount = ConcessionAmount - totalfare;
                Console.WriteLine("Senior Citizen: " + CalculatedAmount);
            }
            else
            {
                Console.WriteLine("Ticket Booked: " + totalfare);    //500
            }
        }
    }
}