using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Author> AllAuthors = new List<Author>
            {
                new Author() { ID = 1, DateOfBirth = new DateTime(1802,7,24), Name = "Alexandre Dumas"},
                new Author() { ID = 2, DateOfBirth = new DateTime(2970,9,2), Name = "William Shakespeare"},
                new Author() { ID = 3, DateOfBirth = new DateTime(1998,9,2), Name = "William Faulkner"},
                new Author() { ID = 4, DateOfBirth = new DateTime(1998,9,2), Name = "Henry James"},
                new Author() { ID = 5, DateOfBirth = new DateTime(1998,9,2), Name = "Jane Austen"},
                new Author() { ID = 6, DateOfBirth = new DateTime(1998,9,2), Name = "Charles Dickens"},
                new Author() { ID = 7, DateOfBirth = new DateTime(1998,9,2), Name = "Fyodor Dostoevsky"},
                new Author() { ID = 8, DateOfBirth = new DateTime(1980,9,2), Name = "Ernest Hemingway"}
            };

            List<Book> AllBooks = new List<Book>
            {
                new Book() {ID = 1, AuthorID = 1, Title = "The Corsican Brothers" , PublishDate = 1884, Categories = new List<string>() { "Fiction", "Adventure", "drama" } },
                new Book() {ID = 2, AuthorID = 1, Title = "The Three Musketeers" , PublishDate = 1844, Categories = new List<string>() { "Romance", "Adventure", "Novel" } },
                new Book() {ID = 3, AuthorID = 1, Title = "The Count of Monte Cristo " , PublishDate = 1846, Categories = new List<string>() {"Adventure", "Novel"} },
                new Book() {ID = 4, AuthorID = 2, Title = "The Corsican Brothers" , PublishDate = 1884, Categories = new List<string>() { "Fiction", "Adventure", "Drama", "Sci-fi" } },
                new Book() {ID = 5, AuthorID = 2, Title = "The Corsican Brothers 2" , PublishDate = 1981, Categories = new List<string>() { "Fiction", "Adventure", "Sci-fi" } },
                new Book() {ID = 6, AuthorID = 8, Title = "The Corsican Brothers 2" , PublishDate = 1981, Categories = new List<string>() { "Fiction", "Adventure" } },
                new Book() {ID = 7, AuthorID = 8, Title = "The Corsican Brothers 2" , PublishDate = 1981, Categories = new List<string>() { "Fiction", "Adventure", "Sci-fi" } },
                new Book() {ID = 8, AuthorID = 8, Title = "The Corsican Brothers 2" , PublishDate = 1981, Categories = new List<string>() { "Fiction", "Adventure" } },
                new Book() {ID = 9, AuthorID = 8, Title = "The Corsican Brothers 2" , PublishDate = 1981, Categories = new List<string>() { "Fiction", "Adventure", "Sci-fi" } }
            };

            Library library = new Library(AllBooks);

            foreach (var book in library.Books)
            {
                Console.WriteLine(book.ToString());
            }

            var authors = library.AuthorsID.Join(AllAuthors,
                authorID => authorID,
                author => author.ID,
                (authorID, author) => author
                );

            Console.WriteLine("\n\nBefore adding a new book\n\n");
            foreach (var author in authors)
            {
                Console.WriteLine(author.ToString());
            }

            library.AddBook(new Book()
            {
                ID = 10,
                AuthorID = 5,
                Title = "The Corsican Brothers 2",
                PublishDate = 1995,
                Categories = new List<string>() { "Fiction", "Adventure" }
            });

            Console.WriteLine("\n\nAfter adding a new book\n\n");

            foreach (var author in authors)
            {
                Console.WriteLine(author.ToString());
            }
        }
    }
}
