using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Program
    {
        public int Accountnum;
        public string Customername;
        string Accounttype;
        char Transactiontype;
        float Amount;
        float Balance;


        public static void Main(string[] args)
        {
            Program p = new Program(1341571, "Saving", "Savitha");
            p.Amount = 0.1f;
            p.Balance = 30000.00f;
            p.ShowData();

            Console.WriteLine("Enter transaction type 'D' for Deposit and 'W' for Withdrawl ");
            p.Transactiontype = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Amount");
            p.Amount = Convert.ToSingle(Console.ReadLine());

            p.Balance = p.Ttype(p.Amount, p.Transactiontype);

            //after transactions
            Console.WriteLine("******************After Transaction*******************");
            p.ShowData();

            //student details
            Student s = new Student(116, "Savitha", "3year", "BCA", "6");
            s.Getmarks();
            s.DisplayResult();
            s.DisplayData();
            Console.ReadLine();
        }
        public Program(int num, string atype, string cname)
        {
            Accountnum = num;
            Accounttype = atype;
            Customername = cname;
        }
        public float Ttype(float amount, char Type)
        {
            if ('D' == Type)
            {
                return Credit(amount);
            }
            else if ('W' == Type)
            {
                return Debit(amount);
            }
            else
            {
                return 0;
            }
        }
        public float Credit(float deposit)
        {
            Balance = Balance + deposit;
            return Balance;
        }
        public float Debit(float Withdrawl)
        {
            Balance = Balance - Withdrawl;
            return Balance;
        }

        public void ShowData()
        {
            Console.WriteLine("********* Account Details**********");
            Console.WriteLine("Account Number: " + Accountnum);
            Console.WriteLine("Account Type: " + Accounttype);
            Console.WriteLine("Balance: " + Balance);

        }
    }
    
    //student
    
    class Student
    {
        int rollNum;
        string name;
        string year;
        string branch;
        string sem;

        int[] mark = new int[5];  //array

        int Total;
        int avg;
        string result;
        int Count = 0;

        public Student(int rollNum, string name, string year, string branch, string sem)
        {
            this.rollNum = rollNum;
            this.name = name;
            this.year = year;
            this.branch = branch;
            this.sem = sem;

        }
        public void Getmarks()
        {
            Console.WriteLine("Enter the marks");
            for (int i = 0; i < mark.Length; i++)
            {
                Console.WriteLine("enter the marks for subject:{0} ", i + 1);
                mark[i] = Convert.ToInt32(Console.ReadLine());
                if (mark[i] < 35)
                {
                    Count++;
                }

                Total = mark[i] + Total;
            }
            Console.WriteLine("Total of given marks : " + Total);
        }
        public void DisplayResult()
        {
            avg = Total / mark.Length;

            if (Count > 0 && avg < 50)
            {
                result = "Fail";
            }
            else
            {
                result = "Pass";
            }


        }

        public void DisplayData()
        {
            Console.WriteLine("*******Student Details********");
            Console.WriteLine("Roll Number: " + rollNum);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Year of Studying: " + year);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Semester: " + sem);
            Console.WriteLine("Result is: " + result);
        }

    }
}



