using Dicta_Sanctorum.Data.InterfacesRepository;
using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Controllers
{
    public class SaintController : Controller
    {
        private readonly ISaintRepository _saintRepository;

        public SaintController(ISaintRepository saintRepository)
        {
            _saintRepository = saintRepository;
        }


        public IActionResult Index()
        {
           var saints= _saintRepository.GetAll();

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
            _saintRepository.Add(saintModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id) { 
            
            var saint = _saintRepository.GetById(id);
            return View(saint);
        }
        [HttpPost]
        public IActionResult Edit(SaintModel saint)
        {
            _saintRepository.Edit(saint);
            return View(saint);
        }
        public IActionResult Delete(int id) {
            
            var saint = _saintRepository.GetById(id);
            return View(saint);
        }

        [HttpPost]
        public IActionResult Delete(SaintModel saint)
        {
            _saintRepository.Delete(saint);
            return View();
        }
    }
}
