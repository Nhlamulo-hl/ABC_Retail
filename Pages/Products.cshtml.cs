using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ABC_Retail.Pages
{
    public class ProductsModel : PageModel
    {
        public IEnumerable<Product>? Products { get; set; }

        public Task OnGetAsync()
        {
            // Replace with your data access logic
            Products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Product 1", Price = 10.99m },
            new Product { ProductId = 2, ProductName = "Product 2", Price = 9.99m },
            // ...
        };
            return Task.CompletedTask;
        }
    }
}
