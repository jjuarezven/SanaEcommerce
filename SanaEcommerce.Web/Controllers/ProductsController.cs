using Microsoft.AspNetCore.Mvc;
using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Services.Interfaces;
using System.Threading.Tasks;

namespace SanaEcommerce.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Products
        public async Task<IActionResult> Index(string storageMode)
        {
            ViewData["storageMode"] = storageMode ?? "database";
            if ((string)ViewData["storageMode"] == "database")
            {
                return View(_productService.GetAll());
            }
            else
            {
                return View(_productService.GetAllFromInMemory());
            }
        }

        // GET: Products/Create
        public IActionResult Create(string storageMode)
        {
            ViewData["storageMode"] = storageMode ?? "database";
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, string storageMode)
        {
            bool success;
            if (ModelState.IsValid)
            {
                ViewData["storageMode"] = storageMode ?? "database";
                if ((string)ViewData["storageMode"] == "database")
                {
                    success = _productService.Save(product);
                }
                else
                {
                    success = _productService.SaveToInMemory(product);
                }

                if (success)
                {
                    return RedirectToAction(nameof(Index), new { storageMode  = (string)ViewData["storageMode"] });
                }
                else
                {
                    return View(product);
                }
            }
            return View(product);
        }
    }
}
