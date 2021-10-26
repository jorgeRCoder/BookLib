using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLib;
using System.IO;

namespace BookLibConsole
{

    class Program
    {

        enum PetType
        {
            None,
            Cat = 1,
            Dog = 2
        }
        static void Main(string[] args)
        {
            //PetType pet = (PetType)Enum.Parse(typeof(PetType), "Dog");
            //if (pet == PetType.Dog)
            //{
            //    Console.WriteLine("Equals dog.");
            //}

            //Book.Genre genre = (Book.Genre)Enum.Parse(typeof(Book.Genre), "Arts");
            //if (genre == Book.Genre.Arts)
            //{
            //    Console.WriteLine("Equals Genre.");
            //}

            Book book0 = new Book("none", 2020, "me1", "hill", 1.1, 1, "Computers", 1);
            Book book1 = new Book("before the era", 2020, "me1", "hill", 1.1, 1, "Computers", 1);
            Book book2 = new Book("after", 2020, "dfgdfg", "hill", 1.1, 1, "Computers", 1);
            Book book3 = new Book("before3", 2021, "me1", "hill", 1005, 1, "Computers", 1);

            Journal j0 = new Journal("none", 2000, "joe", "medical", 10.32, 0);
            Journal j1 = new Journal("before medicine", 2000, "joe", "medical", 10.32, 4);
            Journal j2 = new Journal("after medicine", 2001, "sam", "medical", 7.6, 5);

            Stock storage = new Stock();
            storage.AddBook(book0, 0);
            storage.AddBook(book1, 1);
            storage.AddBook(book2, 2);
            storage.AddBook(book3, 3);

            storage.AddJournal(j0, 1);
            storage.AddJournal(j1, 1);
            storage.AddJournal(j2, 2);

            Console.WriteLine("Inventory");
            foreach (var item in storage.BooksList)
            {
                Console.WriteLine($"{item} ");
            }

            //Console.WriteLine("title");
            //foreach (var item in storage.SearchBooksTitle("before"))
            //{
            //    Console.WriteLine($"{item} ");
            //}
            Console.WriteLine("=====");
            Console.WriteLine("title,year");

            foreach (var item in storage.SearchBooks2("before"))
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine("=====");
            Console.WriteLine("for: title,year");
            for (int i = 0; i < storage.BooksList.Count; i++)
            {

                   // Console.WriteLine(storage.BooksList[i]. storage.SearchBooks2("before"));
               
                //if (storage.BooksList[i].Title == "before the era")
               // { Console.WriteLine(storage.BooksList[i]); }
            }   

            Console.WriteLine("=====");

            Console.WriteLine("all");
            foreach (var item in storage.JournalList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("j:title,year");

            foreach (var item in storage.SearchJournals2("medicine", 2000, ""))
            {
                Console.WriteLine($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
