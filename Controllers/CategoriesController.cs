using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var categories = context.Categories.ToList();
            return View("Index" , categories);
        }

        public ViewResult Details(int id)
        {
            var categories = context.Categories.Find(id);
            return View("Details", categories);
        }
    }
}
