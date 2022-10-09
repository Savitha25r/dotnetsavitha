using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class traintickets
    {
        static void Main()
        {
            Console.WriteLine("--------Passenger details---------");
            traintickets train = new traintickets();           
            Console.ReadLine();
        }

        public traintickets()
        {
            bool IsBookingFailed;
            Passenger passenger = new Passenger();  //Passenger class

            do
            {
                IsBookingFailed = false;

                string name;
                int age;
                Console.WriteLine("Enter How Many Tickets");  // 2 tickets valid
                try
                {
                    int no_of_tickets = Convert.ToInt32(Console.ReadLine());

                    if (no_of_tickets > 2)
                    {
                        passenger.TicketBooking(no_of_tickets);
                    }

                    else if (no_of_tickets == 2)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("Enter the Name of the Passanger: {0}", i + 1);
                            name = Console.ReadLine(); //name
                            Console.WriteLine("Enter the Age of the Passanger: {0}", i + 1);
                            age = Convert.ToInt32(Console.ReadLine()); //age converstion to int32
                            passenger.TwoPassanger(name, age, i);
                        }
                        passenger.TicketBooking(no_of_tickets);
                    }
                    else
                    {
                        Console.WriteLine("Enter the Name of the Passanger: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the Age of the Passanger: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        passenger.OnePassenger(name, age);
                        passenger.TicketBooking(no_of_tickets);

                    }
                }
                catch (NoOfPersonException ne) // if it exceeds excepetion throws
                {
                    Console.WriteLine("Ticket Booking Failed: " + ne.Message);
                    IsBookingFailed = true;
                }
                catch (FormatException fe)       //fe=FormatException The exception that is thrown when the format of an argument is invalid, or when
                                                 //     a composite format string is not well formed.
                {
                    Console.WriteLine("Invalid details:" + fe.Message);
                    IsBookingFailed = true;
                }
            } while (IsBookingFailed == true); // used for get the user inputs again to book the tickets after getting exception

        }
    }
    class Passenger
    {
        private string[] Name = new string[2];        //two names beacuse two passengers so it stores 2 
        private int[] Age = new int[2];
        public void OnePassenger(string Name, int Age)     //one passenger
        {
            this.Name[0] = Name;
            this.Age[0] = Age;
        }
        public void TwoPassanger(string Name, int Age, int i)      //two passenger
        {

            this.Name[i] = Name;
            this.Age[i] = Age;

        }
        public void TicketBooking(int no_of_tickets)            //ticket booking
        {
            if (no_of_tickets > 2)        //if it is more than 2 it throws an exception  like Cannot book more than two tickets
            {
                throw (new NoOfPersonException("Cannot book more than two tickets "));
            }
            else
            {

                TicketStatus(no_of_tickets);// here if we give correct tickets 2 or 1 it gives correct message calling the method to print the ticket status along with no of tickets only ticket booking is successfully done
            }
        }
        public void TicketStatus(int no_of_tickets) // check status of ticket and display passessenger details
        {
            if (no_of_tickets == 2)
            {

                for (int i = 0; i < 2; i++)// if it is two, print the two passenger details and Ticketstatus 
                {
                    Console.WriteLine("Passenger Name: " + Name[i]);
                    Console.WriteLine("Passanger Age: " + Age[i]);
                    Console.WriteLine("Total number of passangers: " + no_of_tickets);
                    Console.WriteLine();
                }
                Console.WriteLine("-------Ticket Booked Successfully--------");
            }
            else //if it is one, print the two passenger details and Ticketstatus
            {
                Console.WriteLine("Passenger Name: " + Name[0]);
                Console.WriteLine("Passanger Age: " + Age[0]);
                Console.WriteLine("Total number of passangers: " + no_of_tickets);
                Console.WriteLine("---------Ticket Booked Successfully---------");
            }
        }
    }
    class NoOfPersonException : ApplicationException  //User Defined Exception
    {
        public NoOfPersonException(string msg) : base(msg)       //Serves as the base class for application-defined exceptions.
        {

        }
    }
}

    
