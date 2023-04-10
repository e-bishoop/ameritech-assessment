using ADS.Blazor.Assessment.Client.Pages;
using ADS.Blazor.Assessment.Server.Models;
using ADS.Blazor.Assessment.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ADS.Blazor.Assessment.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ModelContext _context;


        public ProductController(ModelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<IEnumerable<ProductDto>> GetProducts(int category)
        {
            // we need to return an IEnumerable for ProductDto. 
            // since Product is a different data type, we convert as we iterate through the data
            IEnumerable<ProductDto> products = new List<ProductDto>();

            // if a category number is provided, sort by that category
            if (category != 0) {

                foreach (var product in _context.Products.Where(x => x.Category!.Id == category))
                {
                    ProductDto temp = new ProductDto();
                    temp.Id = product.Id;
                    temp.Name = product.Name;
                    temp.Price = product.Price;
                    temp.Size = product.Size;

                    temp.Category = new CategoryDto();
                    temp.Category.Id = category;
                    temp.Category.Name = product.Category!.Name;

                    products.Append(temp);
                }
            }
            //otherwise if default (category 0), display all
            else
            {
                foreach (var product in _context.Products)
                {
                    ProductDto temp = new ProductDto();
                    temp.Id = product.Id;
                    temp.Name = product.Name;
                    temp.Price = product.Price;
                    temp.Size = product.Size;

                    temp.Category = new CategoryDto();
                    temp.Category.Id = product.Category.Id;
                    temp.Category.Name = product.Category.Name;

                    products.Append(temp);
                }
            }
            

            return Task.FromResult(products);

            //throw new NotImplementedException();
        }

    }
}
