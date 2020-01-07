using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Services.Interfaces;
using SanaEcommerce.Web.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanaEcommerce.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: Products
        public async Task<IActionResult> Index(string storageMode)
        {
            ViewData["storageMode"] = storageMode ?? "database";
            IEnumerable<Product> products;
            if ((string)ViewData["storageMode"] == "database")
            {
                products = await _productService.GetAll();
            }
            else
            {
                products = await _productService.GetAllFromInMemory();
            }
            IEnumerable<ProductViewModel> productsViewModel = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            if (productsViewModel.Any())
            {
                return View(productsViewModel);
            }
            return View();
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
                    success = await _productService.Save(product);
                }
                else
                {
                    success = await _productService.SaveToInMemory(product);
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
