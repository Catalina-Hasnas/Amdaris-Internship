using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DtoModels
{
    public class ProductDto
    {       
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }       
        public string Title { get; set; }       
        public DateTime CreatedAt { get; set; }
        public CategoryDto Category { get; set; }
    }
}
