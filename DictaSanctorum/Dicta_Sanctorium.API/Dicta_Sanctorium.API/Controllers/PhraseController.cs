using Dicta_Sanctorium.API.Domain;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Dicta_Sanctorium.API.Controllers
{
    public class PhraseController
    {
        //private readonly IPhraseService _phraseService;

        public PhraseController()
        {
            
        }

        [HttpGet,Route("teste")]
        public async Task<ActionResult<IEnumerable<Phrase>>> GetPhrases()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Phrase>> GetPhrase(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhrase(int id, Phrase phrase)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult<Phrase>> PostPhrase(Phrase phrase)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Phrase>> DeletePhrase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
