using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
	class Program
	{

		static void Main(string[] args)
		{

			//array
			#region
			Program program = new Program();

			//min and max value finding
			program.MaxAndMin();

			//exercise 2 on array
			Console.WriteLine("Enter 10marks");
			program.ex2();
			#endregion
			//string 
			#region


			//assecnding 
			Console.WriteLine("*********ascending************");
			Ascending a = new Ascending();
			a.asc();

			//descending
			Console.WriteLine("*********descending************");
			Descending d = new Descending();
			d.dsc();

			//strin length
			StrEx ex = new StrEx();
			Console.WriteLine("enter the name");
			string name = Console.ReadLine();
			ex.length(name);

			//string reverse
			Console.WriteLine("****************String reversing*************");
			Console.WriteLine(ex.Reverse(name));
			Console.WriteLine();

			//string comparision
			Console.WriteLine("enter first name and last name to check whether both are equal");
			string fname = Console.ReadLine();
			string lname = Console.ReadLine();
			ex.comparision(fname, lname);




			//palindrome
			Console.Write("Enter a string to Check Palindrome : ");
			StrEx.palindrome();
			Console.Read();
			#endregion
		}
		public void MaxAndMin()
		{
			float sum = 0f;
			int max, min;

			int[] arr = new int[] { 3, 5, 11, 8, 6, 2 };
			max = arr[0];
			min = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			Console.WriteLine("maximum value in array is " + max);
			Console.WriteLine("minimum value in array is " + min);

			for (int i = 0; i < arr.Length; i++)
			{
				sum = arr[i] + sum;
			}
			sum = sum / arr.Length;
			Console.WriteLine("average of an array is " + sum);

		}
		public void ex2()
		{

			int sum = 0;
			int mx;
			int mn;

			int[] marks = new int[10];



			//Inputs -- Marks

			for (int i = 0; i < marks.Length; i++)
			{
				marks[i] = Convert.ToInt32(Console.ReadLine());
			}

			mx = marks[0];
			mn = marks[0];

			//finding min and max marks
			for (int j = 1; j < marks.Length; j++)
			{
				if (marks[j] < mn)
				{
					mn = marks[j];
				}

				if (marks[j] > mx)
				{
					mx = marks[j];
				}
			}


			//printing  min marks
			Console.WriteLine("maximum mark is " + mx);
			Console.WriteLine("minimum mark is " + mn);

			//finding avg of marks.
			for (int i = 0; i < marks.Length; i++)
			{
				sum = marks[i] + sum;
			}
			//printing totalmarks
			Console.WriteLine("Total mark is " + sum);
			sum = sum / marks.Length;

			//printing avg marks.
			Console.WriteLine("average mark is " + sum);

		}

		//Write a program in C# to accept two words from user and find out if they are same. 


		// Write a program in C# to accept a word and to find out whether the given word is a palindrome or not.
		public class StrEx
		{


			public void length(string name)
			{
				int lengthOfName = name.Length;
				Console.WriteLine("length of the string name is " + lengthOfName);
			}
			public string Reverse(string name)
			{
				if (name.Length <= 1)
				{
					return name;
				}
				else
				{
					return Reverse(name.Substring(1)) + name[0];
				}

			}
			public void comparision(string fname, string lname)
			{

				if (String.Equals(fname, lname))
					Console.WriteLine($"{fname} and {lname} have same value.");
				else
					Console.WriteLine($"{fname} and {lname} are different.");
			}
			public static void palindrome()
			{


				string name = Console.ReadLine();
				string reverse = string.Empty;



				for (int i = name.Length - 1; i >= 0; i--)
				{
					reverse += name[i];
				}



				if (name == reverse)
				{
					Console.WriteLine($"{name} is Palindrome.");
				}
				else
				{
					Console.WriteLine($"{name} is not Palindrome");
				}

			}
		}
	}


}

public class Ascending
{

	public void asc()
	{
		int i, j;
int[] a = new int[10];
for (i = 0; i < 10; i++)
{
	Console.WriteLine("enter the Marks" + " " + (i + 1) + ":");
	a[i] = Convert.ToInt16(Console.ReadLine());
}
for (i = 0; i < 10; i++)
{
	for (j = 0; j < 9; j++)
	{
		if (a[j] > a[j + 1])

		{
			int temp = a[j + 1];
			a[j + 1] = a[j];
			a[j] = temp;
		}
	}
}
Console.WriteLine("Ascending Order:");
for (i = 0; i < 10; i++)
{
	Console.WriteLine(a[i] + "");
}

        }
    }



public class Descending

{ 
	public void dsc()
	{
	int i, j;
	int[] a = new int[20];
	for (i = 0; i < 10; i++)
	{
		Console.WriteLine("enter the Marks" + " " + (i + 1) + ":");
		a[i] = Convert.ToInt16(Console.ReadLine());
	}
	for (i = 0; i < 10; i++)
	{
		for (j = 0; j < 9; j++)
		{
			if (a[j] < a[j + 1])

			{
				int temp = a[j + 1];
				a[j + 1] = a[j];
				a[j] = temp;
			}
		}
	}
	Console.WriteLine("Descending order:");
	for (i = 0; i < 10; i++)
	{
		Console.WriteLine(a[i] + "");
	}
	Console.ReadKey();
}
    }
