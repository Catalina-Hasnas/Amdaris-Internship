using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int PublishDate { get; set; }
        public int AuthorID { get; set; }
        public List<string> Categories { get; set; }

        public override string ToString()
        {
            string categories = String.Join(", ", Categories);
            return $"({ID}) Title: {Title}, PublishDate: {PublishDate}" +
                $"\n\t Categories: ({categories})";
        }
    }
}
