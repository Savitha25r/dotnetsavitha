using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{

    /* Create a structure 
       struct Books 
       private string title;
       private string author;
       private string subject;
       private int book_id;
    Include 2 methods called GetValues() and ShowValues() to accept and display details.
    create a Class called TestStructures that invokes the above methods of the structure to accept
    and display the details of the book */

    struct Books
    {
        private string title;
        private string Author;
        private string Subject;
        private int book_id;

        //Include 2 methods called GetValues() and ShowValues()
        public void GetValues()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Book ID: " + book_id);

        }
        public void ShowValues(string t, string a, string s, int b)
        {
            title = t;
            Author = a;
            Subject = s;
            book_id = b;
        }

    }

    /* create a Class called TestStructures that invokes the above methods of the structure to accept
    and display the details of the book*/
    class program2TestStructures
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Display Book Details----------");
            Books books = new Books();
            books.ShowValues("Romeo and juliet", "William Shakespeare", "Romantic love", 1594);
            books.GetValues();
            Console.Read();
        }
    }
}



