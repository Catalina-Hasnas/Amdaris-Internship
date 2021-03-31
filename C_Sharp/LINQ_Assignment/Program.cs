using System;
using System.Collections.Generic;

namespace LINQ_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var author1 = new Author { Id = 1, Name = "author1", DateOfBirth = 1981 };
            var books = new List<Book>
            {
                new Book { Id = 1, Name = "book1", PublishDate = 1989,
                    Categories = new List<Category> {
                        new Category {Id = 1, Name = "drama" },
                        new Category {Id = 2, Name = "sci-fi"}
                    },
                    Author = author1,
                }
            };

            Console.WriteLine(books[0].ToString());
        }
    }
}
