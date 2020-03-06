using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Infrastructure;

namespace ShoppingCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ShoppingCartContext context;

        public CategoriesController(ShoppingCartContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}