﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment7
{
   
/*1. Create a console application and add class named Employee with following field.
            Employee Class
            EmployeeID (Integer)
            FirstName (String)
            LastName (String)
            Title (String)
            DOB (Date)
            DOJ (Date)
            City (String)
            */
        class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }



        //function to create a list of student details

        /*2. Create a Generic List Collection empList and populate it with the following records.

            EmployeeID 	FirstName	   LastName 		Title 		DOB 			DOJ 			City
            1001		     Malcolm  	     Daruwalla 	Manager 		16/11/1984 	8/6/2011 		Mumbai

            1002 		Asdin	     Dhalla 		AsstManager 	20/08/1984 	7/7/2012 		Mumbai

            1003 		Madhavi 	     Oza 		     Consultant 	14/11/1987 	12/4/2015 	Pune

            1004 		Saba 		Shaikh		SE 			3/6/1990	 	2/2/2016	 	Pune

            1005 		Nazia 		Shaikh 		SE 			8/3/1991 		2/2/2016	 	Mumbai

            1006 		Amit 		Pathak 		Consultant 	7/11/1989 	8/8/2014 		Chennai

            1007 		Vijay 		Natrajan	 	Consultant 	2/12/1989	 	1/6/2015 		Mumbai

            1008 		Rahul 		Dubey 		Associate	 	11/11/1993 	6/11/2014	 	Chennai

            1009 		Suresh 		Mistry		Associate 	12/8/1992 	3/12/2014 	Chennai

            1010 		Sumit 		Shah 		Manager 		12/4/1991 	2/1/2016 		Pune*/
        public static List<Employee> GetEmployee()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{EmployeeID=1001,FirstName=" Malcolm",LastName= "Daruwalla", Title= "Manager",City="Mumbai"},               
                new Employee{EmployeeID=1002,FirstName="Asdin",LastName= "Daruwalla", Title= "AsstManager",City="Mumbai"},
                new Employee{EmployeeID=1003,FirstName="Madhavi ",LastName= "Oza ", Title= "Consultant ",City="Pune"},
                new Employee{EmployeeID=1004,FirstName="Saba",LastName= "Shaikh ", Title= "SE  ",City="Pune"},
                new Employee{EmployeeID=1005,FirstName="Nazia",LastName= "Shaikh ", Title= "SE  ",City="Mumbai"},
                new Employee{EmployeeID=1006,FirstName="Amit",LastName= "Pathak ", Title= "Consultant ",City="Chennai"},
                new Employee{EmployeeID=1007,FirstName="Vijay",LastName= "Natrajan ", Title= "Consultant",City="Mumbai"}
                new Employee{EmployeeID=1008,FirstName="Rahul",LastName= "Dubey ", Title= "Associate",City="Mumbai"},
                new Employee{EmployeeID=1009,FirstName="Suresh",LastName= "Mistry ", Title= " Associate ",City="Chennai"},
                new Employee{EmployeeID=1010,FirstName="Sumit",LastName= "Shah ", Title= "Manager ",City="Pune"},
            };
            return emplist;
        }
    }


    /*3. Now once the collection is created write down and execute the LINQ queries for collection 
                as follows :

                a. Display detail of all the employee
                b. Display details of all the employee whose location is not Mumbai
                c. Display details of all the employee whose title is AsstManager
                d. Display details of all the employee whose Last Name start with S
                e. Display a list of all the employee who have joined before 1/1/2015
                f. Display a list of all the employee whose date of birth is after 1/1/1990
                g. Display a list of all the employee whose designation is Consultant and Associate
                h. Display total number of employees
                i. Display total number of employees belonging to “Chennai”
                j. Display highest employee id from the list
                k. Display total number of employee who have joined after 1/1/2015
                l. Display total number of employee whose designation is not “Associate”
                m. Display total number of employee based on City
                n. Display total number of employee based on city and title
                o. Display total number of employee who is youngest in the list*/
    class QueryExpressions
    {
        static void Main(string[] args)
        {

        }

    }
}
