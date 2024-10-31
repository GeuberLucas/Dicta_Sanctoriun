using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Dicta_Sanctorum.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Controllers
{
    public class PhraseController : Controller
    {
        public DbContextOptions<EntityContext> _options { get; }

        public PhraseController(DbContextOptions<EntityContext> options)
        {
            _options = options;
        }

        public IActionResult Index()
        {
            var phrases= new PhraseRepository().GetAll();

            return View(phrases);
        }

        public IActionResult Add()
        {
            var phrase = new PhraseModel();
            return View(phrase);
        }

        public IActionResult Add(PhraseModel phraseModel)
        {
            new PhraseRepository().Add(phraseModel);
            return View(phraseModel);
        }

        public IActionResult Edit(int id)
        {

            var phrase = new PhraseRepository().GetById(id);
            return View(phrase);
        }

        [HttpPost]
        public IActionResult Edit(PhraseModel phrase)
        {
           new PhraseRepository().Edit(phrase);
            return View(phrase);
        }


        public IActionResult Delete(int id)
        {
            var phrase = new PhraseRepository().GetById(id);
            return View(phrase);
        }

        public IActionResult Delete(PhraseModel phrase)
        {
            new PhraseRepository().Delete(phrase);
            return View();
        }
    }
}
