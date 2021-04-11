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
                new Author() { ID = 2, DateOfBirth = new DateTime(1564,1,1), Name = "William Shakespeare"},
                new Author() { ID = 3, DateOfBirth = new DateTime(1897,9,25), Name = "William Faulkner"},
                new Author() { ID = 4, DateOfBirth = new DateTime(1843,4,15), Name = "Henry James"},
                new Author() { ID = 5, DateOfBirth = new DateTime(1931,5,7), Name = "Toni Morrison"},
                new Author() { ID = 6, DateOfBirth = new DateTime(1932,12,2), Name = "Margaret Atwood"},
                new Author() { ID = 7, DateOfBirth = new DateTime(1821,9,2), Name = "Fyodor Dostoevsky"},
                new Author() { ID = 8, DateOfBirth = new DateTime(1920,9,2), Name = "Isaac Asimov"}
            };

            List<Book> AllBooks = new List<Book>
            {
                new Book() {ID = 1, AuthorID = 1, Title = "The Corsican Brothers" , PublishDate = 1884, Categories = new List<string>() { "Fiction", "Adventure", "Drama" } },
                new Book() {ID = 2, AuthorID = 1, Title = "The Three Musketeers" , PublishDate = 1844, Categories = new List<string>() { "Romance", "Adventure", "Novel" } },
                new Book() {ID = 3, AuthorID = 2, Title = "Hamlet" , PublishDate = 1601, Categories = new List<string>() {"Tragedy", "Drama"} },
                new Book() {ID = 4, AuthorID = 3, Title = "A Fable" , PublishDate = 1884, Categories = new List<string>() { "Fiction", "Adventure", "Drama", "Sci-fi" } },
                new Book() {ID = 5, AuthorID = 3, Title = "The Portable Faulkner" , PublishDate = 1946, Categories = new List<string>() { "Fiction", "Sci-fi" } },
                new Book() {ID = 6, AuthorID = 3, Title = "The Reivers" , PublishDate = 1962, Categories = new List<string>() { "Fiction", "Adventure", "Humour" } },
                new Book() {ID = 7, AuthorID = 4, Title = "The Portrait of a Lady" , PublishDate = 1981, Categories = new List<string>() { "Fiction", "Novel", "Drama"} },
                new Book() {ID = 8, AuthorID = 4, Title = "The Innocents" , PublishDate = 1961, Categories = new List<string>() { "Fiction", "Horror" } },
                new Book() {ID = 9, AuthorID = 5, Title = "Beloved" , PublishDate = 1987, Categories = new List<string>() { "Drama" } },
                new Book() {ID = 10, AuthorID = 6, Title = "The Handmaid's Tale" , PublishDate = 1985, Categories = new List<string>() { "Fiction", "Adventure", "Sci-fi" } },
                new Book() {ID = 11, AuthorID = 7, Title = "Crime and Punishment" , PublishDate = 1866, Categories = new List<string>() { "Drama", "Psychological Fiction" } },
                new Book() {ID = 12, AuthorID = 7, Title = "The Brothers Karamazov" , PublishDate = 1880, Categories = new List<string>() { "Suspense", "Philosophical fiction", "Novel" } },
                new Book() {ID = 13, AuthorID = 7, Title = "Notes from Underground" , PublishDate = 1864, Categories = new List<string>() { "Philosophical fiction", "Drama" } },
                new Book() {ID = 14, AuthorID = 8, Title = "I, Robot" , PublishDate = 1950, Categories = new List<string>() { "Fiction", "Sci-fi" } },
                new Book() {ID = 15, AuthorID = 8, Title = "Foundation" , PublishDate = 1942, Categories = new List<string>() { "Drama", "Sci-fi" } },
            };

            Library library = new Library(AllBooks);

            var authors = library.AuthorsID.Join(AllAuthors,
                    authorID => authorID,
                    author => author.ID,
                    (authorID, author) => author
                    );

            Console.WriteLine("\n\nList of all authors that have at least one book in the library: \n\n");
            foreach (var author in authors)
            {
                Console.WriteLine(author);
            };

            library.AddBook(new Book()
            {
                ID = 16,
                AuthorID = 6,
                Title = "The Testaments",
                PublishDate = 2019,
                Categories = new List<string>() { "Sci-fi", "Dystopian Fiction" }
            });

            library.RemoveBook(16);

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
