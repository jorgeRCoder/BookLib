using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    public class Book: ReadingMaterial
    {
        private int _edition;
        private string _genre;
        private int _isbn;

   
           /* Arts,
            Biography,
            Money,
            Children,
            Computers,
            Cookboks,
            Health,
            History,
            Literature,
            Science,
            SelfHelp,
            None,*/
    

        public Book()
        {

        }
      
        public static Book Parse(string input)
        {
            var instance = new Book();
            return instance;
        }

        public Book(string title, int yearPrinted, string author,
            string publisher, double price,
            int edition, string genre, int isbn) : base(title, yearPrinted, author, publisher, price)
        {
            _edition = edition;
            _genre = genre;
            _isbn = isbn;
        }

        public int Edition
        {
            get { return _edition; }
            set { _edition = value; }
        }

        public string Genres
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public override string ToString()
        {
            return base.ToString()+$", Edition: {_edition}, Genre: {_genre}, ISBN: {_isbn}"; 
        }

    }
}
