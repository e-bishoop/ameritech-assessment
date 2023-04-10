using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Blazor.Assessment.Shared
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Price { get; set; }
        public string Size { get; set; } = "";
        public CategoryDto? Category { get; set; }

    }
}
