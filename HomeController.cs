using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1
{
    public class HomeController : Controller
    {
        private IPerson _person;

        public HomeController(IPerson person)
        {
            _person = person;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var x = this._person;

            return View();
        }
    }
}
