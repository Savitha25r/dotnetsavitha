using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class student
    {
        static void Main(string[] args)
        {
            Student student = new UndergGraduate();
            student.Name = "Savitha";
            student.StudentId = 116;
            Console.WriteLine("------undergraduate grade is above 70.0--------");//if the grade is above 70.0, then isPassed returns true, otherwise it returns false.
            Console.WriteLine("enter the grade for undergraduate:");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);

            student = new Grades();
            student.Name = "Sunitha";
            student.StudentId = 103;
            Console.WriteLine("------Grades grade is above 80.0--------");
            Console.WriteLine("Enter the grade for Grades");//if the grade is above 80.0, then isPassed returns true, otherwise returns false.
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            Console.Read();

        }

    }

    abstract class Student
    {
        public string Name;   //name
        public int StudentId;     //studentid
        public float grade;      //grade

        public abstract Boolean IsPassed(float grade);         // Boolean Ispassed(grade) which takes grade as an input 

    }

    class UndergGraduate : Student
    {


        public override bool IsPassed(float grade) //overrided the abstract method regarding with the details of UnderGrad class.
        {
            if (grade > 70.0f)
            {
                Console.WriteLine("Passed the course:" + Name + "" + StudentId);
                return true;
            }
            else
            {
                Console.WriteLine("Failed the course:" + Name + "" + StudentId);
                return false;
            }
        }
    }
    class Grades : Student
    {
        public override bool IsPassed(float grade)//overrided the abstract method regarding with the details of Grad class.
        {
            if (grade > 80.0f)
            {
                Console.WriteLine("Passed:" + Name + "" + StudentId);
                return true;
            }
            else
            {
                Console.WriteLine("Failed:" + Name + "" + StudentId);
                return false;
            }
        }


    }

}

