using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Library
    {
        // list of books that's a representation of books stored in library
        private List<Book> books { get; set; }
        // for users, acces to books is provided via IEnumerable property Books
        // IEnumerable provides more flexibility for the user to set the books using any type of IEnumerable (ex. array, list).
        public IEnumerable<Book> Books { get => books; set => books = value.ToList(); }
        // acces to authors is provided via IEnumerable property Authors
        // the way to get it is to select the distinct authors Id from the IEnumerable Book
        // this way, we have a single "source of truth" - Books 
        public IEnumerable<int> AuthorsID
        {
            get
            {
                return Books.Select(a => a.AuthorID).Distinct();
            }
        }
        
        public IEnumerable<Book> DisplayBooksPublishedBefore(int year) => Books.Where(book => book.PublishDate <= year);
        public IEnumerable<Book> DisplayBooksPublishedAfter(int year) => Books.Where(book => book.PublishDate >= year);
        // filters books by category and ignores case
        public IEnumerable<Book> DisplayBooksWithCategory(string category) => Books.Where(book => book.Categories
                                                                            .Any(c => c.Equals(category, StringComparison.OrdinalIgnoreCase)));
        // the constructor receives any type of IEnumerable and sets the Books property
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
            // groups the books by their authors
            .GroupBy(book => book.AuthorID)
            // for each group, creates a new object containing the number of books of each author
            .Select(group => new
            {
                authorID = group.Key,
                nrBooks = group.Count()
            })
            // filters objects where nrBooks property is bigger than the parameter numberOfBooks
            .Where(author => author.nrBooks >= numberOfBooks)
            // joins the List of authors with the previously filtered author Ids and returns a new filtered List of authors 
            .Join(authors,
                author => author.authorID,
                authorInf => authorInf.ID,
                (author, authorInf) => authorInf);

            return result;
        }

        public IEnumerable<Author> AuthorsWithBooksInXCategoryBornBeforeYYear(string category, int birthYear, IEnumerable<Author> authors)
        {
            // creates a variable of type DateTime from the int parameter birthYear
            var year = new DateTime(birthYear, 1, 1);

            // uses the function that filters books by category
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
                                // takes the filtered list of authors that have books of certain category and filters them further by date of birth
                                .Where(authorInf => authorInf.DateOfBirth <= year);

            return result;
        }

        public IEnumerable<IGrouping<int, Book>> DisplayBooksByDecade()
        {
            var result = Books
                .GroupBy(book => book.PublishDate / 10 * 10);
            return result;

            
        }

        

    }
}

