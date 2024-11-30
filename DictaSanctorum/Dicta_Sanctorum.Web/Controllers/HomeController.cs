using Dicta_Sanctorum.Data.InterfacesRepository;
using Dicta_Sanctorum.Models;
using Dicta_Sanctorum.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dicta_Sanctorum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPhraseRepository _phraseRepository;
        private readonly ISaintRepository _saintRepository;

        public HomeController(ILogger<HomeController> logger,IPhraseRepository phraseRepository,ISaintRepository saintRepository)
        {
            _logger = logger;
            _phraseRepository = phraseRepository;
            _saintRepository = saintRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();
            var phraseModel = _phraseRepository.GetRandomPhrase();
            var saintModel = _saintRepository.GetById(phraseModel.idSaint);
            viewModel.phrase = phraseModel.phrase;
            viewModel.SaintName = saintModel.name;
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
