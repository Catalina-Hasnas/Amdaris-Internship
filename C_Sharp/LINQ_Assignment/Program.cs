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

            //var authors = library.AuthorsID.Join(AllAuthors,
            //        authorID => authorID,
            //        author => author.ID,
            //        (authorID, author) => author
            //    );

            library.AddBook(new Book()
            {
                ID = 10,
                AuthorID = 5,
                Title = "The Corsican Brothers 2",
                PublishDate = 1995,
                Categories = new List<string>() { "Fiction", "Adventure" }
            });

            Console.WriteLine("\n\nList of all books: \n\n");
            foreach (var book in library.Books)
            {
                Console.WriteLine(book.ToString());
            };

            Console.WriteLine("\n\nBooks published after 1980 \n\n");
            foreach (var book in library.DisplayBooksPublishedAfter(1980))
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\n\nBooks with drama category \n\n");
            foreach (var book in library.DisplayBooksWithCategory("drama"))
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\n\nAuthors with more than 3 books \n\n");
            foreach (var author in library.AuthorsWithMoreThanXBooks(3, AllAuthors))
            {
                Console.WriteLine(author);
            }

            Console.WriteLine("\n\nAuthors with more than 2 sci-fi books born before 1990 \n\n");
            foreach (var author in library.AuthorsWithBooksInXCategoryBornBeforeYYear("sci-fi", 1990, AllAuthors))
            {
                Console.WriteLine(author);
            }

            Console.WriteLine("\n\nBooks gruped by decade \n\n");
            foreach (var group in library.DisplayBooksByDecade())
            {
                Console.WriteLine(group.Key);

                foreach (Book book in group)
                {
                    Console.WriteLine($"\t{book.Title}");
                }
            }
            
        }

        
    }
}
