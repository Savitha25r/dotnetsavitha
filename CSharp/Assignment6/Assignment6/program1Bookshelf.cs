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
        private string[] BookName = new string[5];
        private string[] AuthorName = new string[5];


        //declare indexers to handle the index of book name field
        public string this[int bname]                   //bname=book name
        {
            get { return BookName[bname]; }
            set { BookName[bname] = value; }
        }

        //declare indexers to handle the index of author name field
        public string this[long aname]                    //aname=authorname
        {
            get { return AuthorName[aname]; }
            set { AuthorName[aname] = value; }
        }

        //write a method Display() to display the details.


        public void Display()
        {
            Console.WriteLine("-------------BookDetails-----------\n");
            for (int i = 0; i < 5; i++)
            {
                 Console.WriteLine($"{BookName[i]},{AuthorName[i]}");
                //Console.WriteLine("Book Name: " + BookName[i] + "\t");
                //Console.WriteLine("Author Name: " + AuthorName[i] + "\n");
            }
        }
    }

    //Create an Indexer of Books Object to store 5 books in a class called BookShelf. 
    // Using the indexer method assign values to the books and display the same.
    class BookShelf
    {
        // books bs=new books();                                        //object store 5 books( bs)
        books bs;
        
        public static void SetIndexer(books bs)
        {

            bs = new books();
            //Console.WriteLine("--------Book Name----------");
            //calling indexers to assign values for book name
            bs[0] = "Hamlet";            // 5book name
            bs[1] = "And There Was None";
            bs[2] = "A Christmas Carol";
            bs[3] = "Harry Potter And The Deathly Hallows";
            bs[4] = "The Tyger";

            //Console.WriteLine("--------Author Name----------");
            //calling indexers to assign values for author name
            bs[0L] = "William Shakespeare";           //5  author name             
            bs[1L] = "Agatha Christie";
            bs[2L] = "Charles Dickens";
            bs[3L] = "J.K Rowling";
            bs[4L] = "William Blake";
            bs.Display();

        }
        public BookShelf()
        {
            SetIndexer(bs);           //composition has a relationship and class containing an object of another class
        }

        class program1Bookshelf
        {
            static void Main(string[] args)
            {
                BookShelf b = new BookShelf();
                Console.Read();
            }
        }

    }

}





