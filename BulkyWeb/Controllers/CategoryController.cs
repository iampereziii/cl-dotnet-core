using Bulky.Data.Context;
using BulkyWeb.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BulkyContext context;
        public CategoryController(BulkyContext context)
        {
            this.context = context;        
        }
        public IActionResult Index()
        {
            List<Category> categoryList = context.Categories.ToList();
            return View();
        }
    }
}
