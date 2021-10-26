using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLib
{
    public class Stock
    {
        private List<ReadingMaterial> _readinMaterial = new List<ReadingMaterial>();
        private List<Book> _books;
        private List<Journal> _journals ;


        public Stock()
        {
            _books = new List<Book>();
            _journals = new List<Journal>();
        }
        
        public List<Book> BooksList
        {
            get { return _books; }
            set { _books = value; }
        }

        public List<Journal> JournalList
        {
            get { return _journals; }
            set { _journals = value; }
        }

        public string AddBook(Book book, int amount)
        {
            if (_books.Contains(book))
            {
                book.Quantity += amount;
                return $"new {book.Title}, amount {book.Quantity}";
            }
            _books.Add(book);
            book.Quantity += amount;
            return $"new {book.Title}, amount {book.Quantity}";
        }

        public string RemoveBook(Book book, int amount)
        {
            if (_books.Contains(book) && book.Quantity >= amount)
            {
                book.Quantity -= amount;
                return $"new {book.Title}, amount {book.Quantity}";
            }
            book.Quantity = 0;
            return $"new {book.Title}, amount {book.Quantity}";
        }

        public string AddJournal(Journal journal, int amount)
        {
            if (_journals.Contains(journal))
            {
                journal.Quantity += amount;
                return $"new {journal.Title}, amount {journal.Quantity}";
            }
            _journals.Add(journal);
            journal.Quantity += amount;
            return $"new {journal.Title}, amount {journal.Quantity}";
        }

        public string RemoveJournal(Journal journal, int amount)
        {
            if (_journals.Contains(journal) && journal.Quantity >= amount)
            {
                journal.Quantity -= amount;
                return $"new {journal.Title}, amount {journal.Quantity}";
            }
            journal.Quantity = 0;
            return $"new {journal.Title}, amount {journal.Quantity}";
        }

        public List<Book> SearchBooksTitle(string title)
        {
            var search = _books.Where(book => book.Title.Contains(title));
            return search.ToList();
        }

        public string SearchBook(string title, int yearPrinted)
        {
            StringBuilder result = new StringBuilder();

            //parse string yearprinted, parse string isbn
            //call searchbookbytitle() get the list returned,
            //and after you have the result you filter by year printed or author

            var resultTitle = _books.Where(book => book.Title.Contains(title));

            //int yearPrintedInt;
            //int.TryParse(yearPrinted, out yearPrintedInt);
            List<Book> resultYearPrinted = new List<Book>();

            foreach (var item in resultTitle)
            {
                if(item.YearPrinted.Equals(yearPrinted))
                {
                    resultYearPrinted.Add(item);
                }
            }
            return resultYearPrinted.ToString();
        }

        public List<Book> SearchBooks2(string title=null, int yearPrinted = 0, string author = null,
            string publisher = null, double price = 0, int edition = 0, 
           string genre = null, int isbn = 0)
        {
            var search = from books in _books
                          where 
                                (/*title == null || */ books.Title.Contains(title))
                             && (yearPrinted == 0 || books.YearPrinted.Equals(yearPrinted))
                             && (author == null || books.Author.Contains(author))
                             && (publisher == null || books.Publisher.Contains(publisher))
                             && (price == 0 || books.Price > (price))
                             && (books.Quantity != 0)
                             && (edition == 0 || books.Edition.Equals(edition))
                             && (genre == null || books.Genres.Contains(genre))
                             && (isbn == 0 || books.ISBN.Equals(isbn))
                         select books;
            return search.ToList();

            //IEnumerable<Book> titles = _books.Where(b => b.Title.Contains(title));
        }

        public List<Journal> SearchJournals2(string title = null, int yearPrinted = 0, string author = null,
            string publisher = null, double price = 0, int id = 0)
        {
            var search = from journals in _journals
                         where
                               (title == null || journals.Title.Contains(title))
                            && (yearPrinted == 0 || journals.YearPrinted.Equals(yearPrinted))
                            && (author == null || journals.Author.Contains(author))
                            && (publisher == null || journals.Publisher.Contains(publisher))
                            && (price == 0 || journals.Price > (price))
                            && (journals.Quantity != 0)
                            && (id == 0 || journals.ID.Equals(id))
                         select journals;
            return search.ToList();

            //IEnumerable<Book> titles = _books.Where(b => b.Title.Contains(title));
        }
        
    }
}

