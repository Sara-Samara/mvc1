using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        public ViewResult Index()
        {

                List<string> users = new List<string>()
        {
            "sara","salma","noha","ahmad","salim"
        };

            return View("Index", users);
        }
    }
}
