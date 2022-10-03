using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Program
    {
        public int AccountNum;
        public string CustomerName;
        string AccType;
        char TransactionType;
        float amount;
        float balance;


        public static void Main(string[] args)
        {
            Program p1 = new Program(1341571, "Savings", "Savitha");
            p1.amount = 0.1f;
            p1.balance = 25000.00f;
            p1.ShowData();
            Console.WriteLine("Enter transaction type 'D' for Deposit and 'W' for Withdrawl ");
            p1.TransactionType = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Amount");
            p1.amount = Convert.ToSingle(Console.ReadLine());
            p1.balance = p1.Ttype(p1.amount, p1.TransactionType);

            //after transactions
            Console.WriteLine("******************After Transaction*******************");
            p1.ShowData();
            Student s = new Student(116, "Savitha", "3year", "BCA", "6");
            s.Getmarks();
            s.DisplayResult();
            s.DisplayData();
            Console.ReadLine();
        }
        public Program(int num, string atype, string cname)
        {
            AccountNum = num;
            AccType = atype;
            CustomerName = cname;
        }
        public float Ttype(float amount, char Type)
        {
            if ('d' == Type)
            {
                return Credit(amount);
            }
            else if ('w' == Type)
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
            balance = balance + deposit;
            return balance;
        }
        public float Debit(float Withdrawl)
        {
            balance = balance - Withdrawl;
            return balance;
        }

        public void ShowData()
        {
            Console.WriteLine("********* Account Details**********");
            Console.WriteLine("Account Number: " + AccountNum);
            Console.WriteLine("Account Type: " + AccType);
            Console.WriteLine("Balance: " + balance);

        }
    }
    class Student
    {
        int rollNum;
        string name;
        string year;
        string branch;
        string sem;
        int[] mark = new int[5];
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



