using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublishDate { get; set; }
        public Author Author { get; set; }

        public List<Category> Categories { get; set; }

        public override string ToString() => $"(Id: {Id}, Name: {Name}, Publish Date: {PublishDate}, Author: {Author}, " +
            $"Categories { String.Join(", ", Categories.Select(category => category.Name)) } )";
    }
}
