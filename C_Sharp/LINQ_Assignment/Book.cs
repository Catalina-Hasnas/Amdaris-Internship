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
            StringBuilder res = new StringBuilder();
            string categories = String.Join(", ", Categories);

            res.AppendFormat($"({ID})");
            res.AppendFormat($" Title: {Title}");
            res.AppendFormat($" Publish Date: {PublishDate}");
            res.AppendFormat($" Categories: {categories}");

            return res.ToString();
        }
    }
}
