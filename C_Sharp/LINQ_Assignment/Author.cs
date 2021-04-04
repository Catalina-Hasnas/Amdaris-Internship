using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.AppendFormat("({0})", ID);
            res.AppendFormat(" Name: {0},", Name);
            res.AppendFormat(" Date of Birth: {0},", DateOfBirth.ToString("dd/MM/yyyy"));

            return res.ToString();
        }

    }
}
