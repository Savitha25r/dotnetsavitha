using System;
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
        public static List<Employee> GetEmployee()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{EmployeeID=1001,FirstName=" Malcolm",LastName= "Daruwalla", Title= "Manager",City="Mumbai"},
                new Employee{EmployeeID=1002,FirstName="Asdin",LastName= "Daruwalla", Title= "Manager",City="Mumbai"},

            };
            return emplist;
        }
    }

    class QueryExpressions
    {
        static void Main(string[] args)
        {

        }

    }
}
