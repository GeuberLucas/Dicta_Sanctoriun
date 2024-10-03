using Microsoft.AspNetCore.Mvc;

namespace Dicta_Sanctorum.Controllers
{
    public class SaintController : Controller
    {
        public SaintController()
        {
            
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetAll()
        {

            return View();
        }

        public IActionResult GetById(int id)
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit() { 
            return View();
        }

        public IActionResult Delete() {
            return View();
        }

    }
}
