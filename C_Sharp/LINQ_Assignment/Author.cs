using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DateOfBirth { get; set; }

        public IEnumerable<Book> Books { get; set; }

        public override string ToString() => $"(Id: {Id}, Name: {Name}, Publish Date: {DateOfBirth})";
    }
}
