using Microsoft.AspNetCore.Mvc;

namespace ПР37_Осокин.Controllers
{
    public class HomeController : Controller
    {
        public RedirectResult Index()
        {
            return Redirect("/Items/List");
        }
    }
}
