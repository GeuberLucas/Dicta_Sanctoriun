using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Dicta_Sanctorum.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Controllers
{
    public class SaintController : Controller
    {

        public SaintController(DbContextOptions<EntityContext> options)
        {
        }


        public IActionResult Index()
        {
           var saints= new SaintsRepository().GetAll();

            return View(saints);
        }

        public IActionResult Add()
        {
            var saint = new SaintModel();
            return View(saint);
        }

        [HttpPost]
        public IActionResult Add(SaintModel saintModel)
        {
            new SaintsRepository().Add(saintModel);
            return View(saintModel);
        }

        public IActionResult Edit(int id) { 
            
            var saint = new SaintsRepository().GetById(id);
            return View(saint);
        }
        [HttpPost]
        public IActionResult Edit(SaintModel saint)
        {
            new SaintsRepository().Edit(saint);
            return View(saint);
        }
        public IActionResult Delete(int id) {
            
            var saint = new SaintsRepository().GetById(id);
            return View(saint);
        }

        [HttpPost]
        public IActionResult Delete(SaintModel saint)
        {
            new SaintsRepository().Delete(saint);
            return View();
        }
    }
}
