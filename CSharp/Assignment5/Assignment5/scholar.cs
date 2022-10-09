using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /*Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() 
          as its method.
        Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.ShowDetails()
        should show DaysScholar details and
        Resident Details accordingly*/

namespace Assignment5
{
    class scholar
    {
        static void Main(string[] args)
        {
            IStudent student = new DayScholor();
            Console.WriteLine("-------DayScholor-------");
            student.Name = "Savitha";
            student.StudentId = 116;
            student.ShowDetails();

            IStudent resident = new Resident();
            Console.WriteLine("-------Resident-------");
            resident.Name = "Sunitha";
            resident.StudentId = 103;
            resident.ShowDetails();
            Console.ReadLine();
        }

    }
    //Create an Interface IStudent with int StudentId and string Name as Properties
    //void ShowDetails() as its method.
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    //Create class Dayscholar that implements the interface Properties and Methods.ShowDetails()

    class DayScholor : IStudent  //inheriting interface DayScholor inherits IStudent
    {


        string name;
        int id;
        public int StudentId
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        void IStudent.ShowDetails()
        {           
            Console.WriteLine("Student Id: {0}", id);
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine();

        }
    }


    //Create class Resident that implements the interface Properties and Methods.ShowDetails()

    class Resident : IStudent //inheriting interface interface Resident inherits IStudent
    {

        string name;
        int id;
        public int StudentId
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        void IStudent.ShowDetails()
        {           
            Console.WriteLine("Student Id: {0}", id);
            Console.WriteLine("Student Name: {0}", name);
        }
    }
}