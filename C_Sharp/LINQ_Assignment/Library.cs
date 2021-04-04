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

        public IEnumerable<Book> DisplayBooksPublishedBefore(int year) => Books.Where(book => book.PublishDate <= year);
        public IEnumerable<Book> DisplayBooksPublishedAfter(int year) => Books.Where(book => book.PublishDate >= year);
        public IEnumerable<Book> DisplayBooksWithCategory(string category) => Books.Where(book => book.Categories
                                                                            .Any(c => c.Equals(category, StringComparison.OrdinalIgnoreCase)));

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
       
        public IEnumerable<Author> AuthorsWithMoreThanXBooks(int numberOfBooks, IEnumerable<Author> authors)
        {

            var result = Books   
            .GroupBy(book => book.AuthorID)
            .Select(group => new
            {
                authorID = group.Key,
                nrBooks = group.Count()
            })
            .Where(author => author.nrBooks >= numberOfBooks)
            .Join(authors,
                author => author.authorID,
                authorInf => authorInf.ID,
                (author, authorInf) => authorInf);

            return result;
        }

        public IEnumerable<Author> AuthorsWithBooksInXCategoryBornBeforeYYear(string category, int birthYear, IEnumerable<Author> authors)
        {
            var year = new DateTime(birthYear, 1, 1);

            var result = DisplayBooksWithCategory(category)
                                .GroupBy(book => book.AuthorID)
                                .Select(group => new
                                {
                                    authorID = group.Key,
                                    nrBooks = group.Count()
                                })
                                .Where(author => author.nrBooks >= 2)
                                .Join(authors,
                                author => author.authorID,
                                authorInf => authorInf.ID,
                                (author, authorInf) => authorInf)
                                .Where(authorInf => authorInf.DateOfBirth <= year);

            return result;
        }

        public static int GetDecade(int year)
        {
            return year < 2000 ? (year / 10 * 10 - 1900) : (year / 10 * 10);
        }

        public IEnumerable<IGrouping<int, Book>> DisplayBooksByDecade()
        {
            var result = Books
                .GroupBy(book => book.PublishDate / 10 * 10);
            return result;

            
        }

        

    }
}

