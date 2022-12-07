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
         public class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }



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

       

        //function to create a list of Employee details
        public static List<Employee> GetEmployee()
        {
            List<Employee> emplist = new List<Employee>
            {
               
                new Employee{EmployeeID = 1001,FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager",City = "Mumbai",DOB =  DateTime.Parse("1984/11/16"), DOJ =  DateTime.Parse("2011/8/6") },               
                new Employee{EmployeeID=1002,FirstName="Asdin",LastName= " Dhalla", Title = "AsstManager",City = "Mumbai",DOB = new DateTime(1984,08,20),DOJ =new DateTime(2012,7,7) },

                new Employee{EmployeeID=1003,FirstName="Madhavi ",LastName= "Oza", Title= "Consultant",DOB = new  DateTime(1987,11,14),DOJ = new DateTime(2015,4,12),City="Pune"},
                new Employee{EmployeeID=1004,FirstName="Saba",LastName= "Shaikh", Title= "SE",DOB = new DateTime(1990,6,3),DOJ =new DateTime(2016,2,2),City="Pune"},

                new Employee{EmployeeID=1005,FirstName="Nazia",LastName= "Shaikh", Title= "SE",DOB = new DateTime(1991,3,8),DOJ = new DateTime(2016,2,2) ,City="Mumbai"},
                new Employee{EmployeeID=1006,FirstName="Amit",LastName= "Pathak ", Title= "Consultant ",DOB = new DateTime(1989,11,7),DOJ = new DateTime(2014,8,8 ),City="Chennai"},

                new Employee{EmployeeID=1007,FirstName="Vijay",LastName= "Natrajan ", Title= "Consultant",DOB = new DateTime(1989,12,2),DOJ = new DateTime(2015,6,1 ),City="Mumbai"},
                new Employee{EmployeeID=1008,FirstName="Rahul",LastName= "Dubey ", Title= "Associate",DOB = new DateTime(1993,11,11),DOJ =new DateTime(2014,11,6), City="Mumbai"},

                new Employee{EmployeeID=1009,FirstName="Suresh",LastName= "Mistry", Title= "Associate",DOB = new DateTime(1992,8,12),DOJ = new DateTime(2014,12,3 ),City="Chennai"},
                new Employee{EmployeeID=1010,FirstName="Sumit",LastName= "Shah", Title= "Manager",DOB =  new DateTime(1991,4,12),DOJ = new DateTime(2016,1,2),City="Pune"},
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

            //a.Display detail of all the employee

            var emp = from e in Employee.GetEmployee()
                      select e;

            Console.WriteLine("-------------------Display detail of all the employee-------------------------\n");
            foreach(Employee e in emp)
            {
                
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t ",e.EmployeeID, e.FirstName,e.LastName,e.Title,e.DOB.ToShortDateString(),e.DOJ.ToShortDateString(), e.City);

                Console.WriteLine ("----------------------------------------------------------------------------------------------------");
            }



            // b. Display details of all the employee whose location is not Mumbai

            IEnumerable<Employee> Location = from loc in Employee.GetEmployee()
                                                 
                                                 where loc.City!="Mumbai"
                                            // where loc.City.Contains("Chennai") || loc.City.Contains("Pune")
                                             select loc;

            
            Console.WriteLine("------------------Display details of all the employee whose location is not Mumbai----------------\n");

            foreach (Employee e in Location)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}  ", e.EmployeeID, e.FirstName, e.LastName, e.Title,  e.City);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                //Console.Write("\n");
            }


            // c. Display details of all the employee whose title is AsstManager

            
            IEnumerable<Employee> title = from e in Employee.GetEmployee()
                                          where e.Title.Contains("AsstManager")
                                          select e;

                //Console.WriteLine("-------Title---------");
                Console.WriteLine("------------------Display details of all the employee whose title is AsstManager-----------------------\n");

                foreach (Employee em in title)
                {
                Console.WriteLine("{0}\t{1}\t{2}\t {3} \t{4}\t  ", em.EmployeeID, em.FirstName, em.LastName, em.Title, em.City);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");


            }


            //d.Display details of all the employee whose Last Name start with S
            IEnumerable<Employee> lastname = from ln in Employee.GetEmployee()
                                             where ln.LastName.StartsWith("S")
                                             select ln;


           // Console.WriteLine("-------names start with s---------\n");
            Console.WriteLine("-----------------------------Display details of all the employee whose Last Name start with S------------------\n");

            foreach (Employee str in lastname)
            {
                Console.WriteLine(str.LastName + " \t" + str.Title + " \t" + str.City );
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                
                
            }

            // e. Display a list of all the employee who have joined before 1/1/2015

            List<Employee> ev = (from d in Employee.GetEmployee()
                                    where d.DOB <DateTime.Parse("1/1/2015")
                                    select d).ToList();

            Console.WriteLine("------------------Display a list of all the employee who have joined before 1/1/2015-------------------\n");
            foreach (Employee e in ev)
            {

                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToShortDateString(), e.DOJ.ToShortDateString(), e.City);
                
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
            }





            // f. Display a list of all the employee whose date of birth is after 1/1/1990

            List<Employee> emplo = (from d in Employee.GetEmployee()
                                    where d.DOB > DateTime.Parse("1/1/1990")
                                    select d).ToList();

            Console.WriteLine("------------------------------Display a list of all the employee whose date of birth is after 1/1/1990---------------------------\n");
            foreach (Employee e in emplo)
            {
                Console.WriteLine(e.FirstName + e.DOB.ToShortDateString());
               //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToShortDateString(), e.DOJ.ToShortDateString(), e.City);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    
            }

            //var eds = (from e in Employee.GetEmployee()
            //           where e.DOB > DateTime.Parse("1/1/1990")
            //           select e.FirstName);
            //foreach(Employee g in eds)
            //{
            //    Console.WriteLine(g.DOB);
            //}

            //g. Display a list of all the employee whose designation is Consultant and Associate
            IEnumerable < Employee > desgination = from des in Employee.GetEmployee()
                                                          where des.Title.Contains("Consultant") || des.Title.Contains("Associate")
                                                          select des;

           // Console.WriteLine("--------Designation---------");
            Console.WriteLine("--------------------------Display a list of all the employee whose designation is Consultant and Associate---------------------\n");

            foreach (Employee str in desgination)
            {
                Console.WriteLine(str.FirstName + "\t " + str.LastName + "\t " + str.Title + "\t " + str.City);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                
            }


            //h. Display total number of employees
                        

            var empl = (from e in Employee.GetEmployee()
                        select e).Count();

            Console.WriteLine("Display total number of employees");
            Console.WriteLine("no of employees are :{0}", empl);
            Console.Write("\n");



            // i.Display total number of employees belonging to “Chennai”

            Console.WriteLine("---------------------Display total number of employees belonging to “Chennai--------------------\n");
            var noofemp = from s in Employee.GetEmployee()
                          where s.City == "Chennai"
                          select Employee.GetEmployee();

            Console.WriteLine("employee in chennai :{0}", noofemp.Count());
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            

            //j. Display highest employee id from the list


            var result1 = (from s in Employee.GetEmployee()
                          select s.EmployeeID).Max();
            Console.WriteLine("---------------------------Display highest employee id from the list------------------------------\n");
            Console.WriteLine(result1);
            Console.WriteLine("--------------------------------------------------------------------------");

            //var result1 = Employee.GetEmployee().OrderByDescending(d => d.EmployeeID).ThenByDescending(d => d);
            //foreach(Employee str in result1)
            //{
            //    Console.WriteLine("highest employee id from the list:{0}", str.EmployeeID);
            //    Console.Write("\n");
            //}
            //IEnumerable<Employee> Query = from employ in Employee.GetEmployee()
            //                              where employ.EmployeeID <1011 && employ.EmployeeID >1000
            //                              select employ;

            //foreach (Employee e in Query)

            // {
            // var result1 = Employee.OrderByDescending(c => c.Length).ThenByDescending(c => c);
            // Console.WriteLine("");
            //Console.WriteLine("highest employee id from the list:{0}", e.EmployeeID.ToString());

            //}




            //k.Display total number of employee who have joined after 1 / 1 / 2015
            List<Employee> ys = (from d in Employee.GetEmployee()
                                    where d.DOB < DateTime.Parse("1/1/2015")
                                    select d).ToList();

            Console.WriteLine("-----------------------------Display total number of employee who have joined after 1 / 1 / 2015----------------------------\n");
            foreach (Employee e in ys)
            {
                Console.WriteLine(e.FirstName + e.DOB.ToShortDateString());
                //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToShortDateString(), e.DOJ.ToShortDateString(), e.City);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");

            }


            //l.Display total number of employee whose designation is not “Associate”

            IEnumerable<Employee> asso = from des in Employee.GetEmployee()
                                                where des.Title!= "Associate"
                                         select des;

            //var empobj = from a in Employee.GetEmployee()
            //             where a.Title != "Associate"
            //             select a.Title.Count();
            Console.WriteLine("-----------------------Display total number of employee whose designation is not “Associate-----------------------------------\n");
            foreach (Employee e in asso)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t ", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToShortDateString(), e.DOJ.ToShortDateString(), e.City);
                //Console.WriteLine(e.Title,e.EmployeeID,e.FirstName,e.LastName);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
              
            }
            
            
            //foreach (var v in empobj)
            //{
            //    Console.WriteLine(v.ToString().Count());
            //}
           


            // m. Display total number of employee based on City

            var employee = Employee.GetEmployee().GroupBy(a => a.City);
            foreach(var e in employee)
            {
                Console.WriteLine("-----------------------Display total number of employee based on City------------------------------\n");
                Console.WriteLine(e.Key,e.Count());
                

                Console.WriteLine("The total count of in {0} are : {1}",e.Key,e.Count());
                Console.WriteLine("----------------------------------------------------------------------------------------------------");

            }

            //n. Display total number of employee based on city and title

            

            Console.WriteLine("---------------Display total number of employee based on city and title--------------\n");
            var N1 = Employee.GetEmployee().GroupBy(n => n.City);
            var N2 = Employee.GetEmployee().GroupBy(n => n.Title);
            Console.WriteLine("------------Based on City--------------");
            foreach (var n1 in N1)
            {
                Console.WriteLine("{1}  total number of Employee are based on city  {0}  ", n1.Key, n1.Count());
            }
            Console.WriteLine("--------------based on Title-------------");
            foreach (var n2 in N2)
            {
                Console.WriteLine("{1}  total number Employee are based on  title {0}  ", n2.Key, n2.Count());
                Console.WriteLine("--------------------------------------------------------------------------");

            }




            //var result = Employee.GetEmployee().OrderBy(s => s.City).ThenBy(t => t.Title);

            // Console.WriteLine("-----------------------------Display total number of employee based on city and title---------------------\n"); 
            //foreach (Employee e in result)
            //{
            //    //Console.WriteLine(str.City,str.Title);
            //    Console.WriteLine(e.EmployeeID);
            //    Console.Write("{0} {1}  ", e.Title.Count(), e.City.Count());
            // Console.WriteLine("-------------------------------------------");


            //var ss = (from s in Employee.GetEmployee()
            //          where s.City.Count
            //          select s).Count

            //    Console.WriteLine("employee in chennai :{0}", ss.Count());

            // }






            //o. Display total number of employee who is youngest in the list
            //IEnumerable<Employee> es = from t in Employee.GetEmployee()
            //                            select t;

            var min = Employee.GetEmployee().Max(i => i.DOB.ToShortDateString());
            //var result = Employee.GetEmployee().First(i => i.DOB == min);

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("youngest is: " + min);
            //Console.WriteLine(emp.Max(t => t.DOB.ToShortDateString()));
            //IEnumerable<Employee> result3 = from e in Employee.GetEmployee()
            //                                where e.DOB==DateTime.Parse("11/11/1993")
            //                                select e;

            //Console.WriteLine("------------------Display total number of employee who is youngest in the list----------------------\n");

            //foreach (Employee e in result3)
            //{
            //    Console.WriteLine(e.DOB.ToShortDateString());
            //    Console.WriteLine("-------------------------------------------------------------");
            //}

            //List<Employee> ys = (from d in Employee.GetEmployee()
            //                     where d.DOB < DateTime.Parse("1/1/2015")
            //                     select d).ToList();

            //Console.WriteLine("-----------------------------Display total number of employee who have joined after 1 / 1 / 2015----------------------------\n");
            //foreach (Employee e in ys)
            //{
            //    Console.WriteLine(e.FirstName + e.DOB.ToShortDateString());
            //    //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToShortDateString(), e.DOJ.ToShortDateString(), e.City);
            //    Console.WriteLine("----------------------------------------------------------------------------------------------------");

            //}


        Console.ReadLine();
            


        }
    }

}
