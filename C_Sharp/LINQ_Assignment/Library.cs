using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LINQ_Assignment
{
    class Library
    {
        private List<Book> books { get; set; }

        public IEnumerable<Book> Books { get => books; set => books = value.ToList(); }
        public IEnumerable<int> AuthorsID
        {
            get
            {
                return Books.Select(a => a.AuthorID).Distinct();
            }
        }

        public Library(IEnumerable<Book> books)
        {
            this.Books = books;
        }

        public void AddBook(Book book)
        {
            if (!books.Any(b => b.ID == book.ID))
            {
                books.Add(book);
            }
        }

        public void RemoveBook(int BookID)
        {
            books.RemoveAll(b => b.ID == BookID);
        }

    }
}

