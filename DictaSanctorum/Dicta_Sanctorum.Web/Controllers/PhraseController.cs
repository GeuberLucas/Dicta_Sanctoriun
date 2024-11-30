using Dicta_Sanctorum.Data.InterfacesRepository;
using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Controllers
{
    public class PhraseController : Controller
    {
        private readonly IPhraseRepository _phraseRepository;

        public PhraseController(IPhraseRepository phraseRepository)
        {
            _phraseRepository = phraseRepository;
        }

        public IActionResult Index()
        {
            var phrases= _phraseRepository.GetAll();

            return View(phrases);
        }

        public IActionResult Add()
        {
            var phrase = new PhraseModel();
            return View(phrase);
        }

        [HttpPost]
        public IActionResult Add(PhraseModel phraseModel)
        {
            _phraseRepository.Add(phraseModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {

            var phrase = _phraseRepository.GetById(id);
            return View(phrase);
        }

        [HttpPost]
        public IActionResult Edit(PhraseModel phrase)
        {
           _phraseRepository.Edit(phrase);
            return View(phrase);
        }


        public IActionResult Delete(int id)
        {
            var phrase = _phraseRepository.GetById(id);
            return View(phrase);
        }

        public IActionResult Delete(PhraseModel phrase)
        {
            _phraseRepository.Delete(phrase);
            return View();
        }
    }
}
