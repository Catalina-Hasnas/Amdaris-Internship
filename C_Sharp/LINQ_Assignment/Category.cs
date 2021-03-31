using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"(Id: {Id}, Name: {Name})";
    }

}
