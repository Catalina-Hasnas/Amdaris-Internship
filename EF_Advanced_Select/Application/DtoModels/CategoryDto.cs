using Domain;
using System.Collections.Generic;

namespace Application.DtoModels
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ProductDto> Products { get; set; }
    }
}
