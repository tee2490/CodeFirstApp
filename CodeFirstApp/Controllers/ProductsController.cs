using CodeFirstApp.Models;
using CodeFirstApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View(productService.GetProduct());
        }

        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productService.AddProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = productService.FindProduct(id);
            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }

    }
}
