using System;

namespace Assignment6
{
    /*Create a class called Books with BookName and AuthorName members. Instantiate the class through constructor 
      and also write a method Display() to display the details. 
      Create an Indexer of Books Object to store 5 books in a class called BookShelf. 
      Using the indexer method assign values to the books and display the same.

      (Hint : Use Composition. Books object inside BookShelf class)*/


    //Create a class called Books with BookName and AuthorName members.


    /*indexer: (smart array) 
     * They allow an object to be indexed like an array
     *They are some what similar to properties, as they also have get and set accessors.
     *But the way these accessors operate is different from properties
     *They do not have names like properties, instead use the this keyword 
     *They can be overloaded
     *We should give index values accordingly while setting or getting data from the indexers
      */
    class books
    {

        string BookName;
        string AuthorName;
        //private string[] BookName = new string[5];
        //private string[] AuthorName = new string[5];

        public books(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }

        public void Display()
        {
            Console.WriteLine("the Book {0} was written by {1} \n", BookName, AuthorName);
            
        }
    }

    //Create an Indexer of Books Object to store 5 books in a class called BookShelf. 
    //Using the indexer method assign values to the books and display the same.

    class BookShelf
    {
        books[] b = new books[5];                //b obj

        //declare indexers to handle the index of book name field
        public books this[int bname]                   //bname=book name
        {
            get { return b[bname]; }
            set { b[bname] = value; }
        }

        //declare indexers to handle the index of author name field
        public books this[long aname]                    //aname=authorname
        {
            get { return b[aname]; }
            set { b[aname] = value; }
        }


        static void Main()
        {
            BookShelf bs = new BookShelf();

            Console.WriteLine("------------Book Details-----------\n");

            bs[0] = new books( "Hamlet", "William Shakespeare");                 // 5book name and author name
            bs[1] = new books("And There Was None", "Agatha Christie");
            bs[2] = new books("A Christmas Carol", "Charles Dickens");
            bs[3] = new books("Harry Potter And The Deathly Hallows", "J.K Rowling");
            bs[4] = new books("The Tyger", "William Blake");

               for (int i = 0; i < 5; i++)

               {
                    bs[i].Display();
               }

            
            Console.Read();
        }
    }
}

