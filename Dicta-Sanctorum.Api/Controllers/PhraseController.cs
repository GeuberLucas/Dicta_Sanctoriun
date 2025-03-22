using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dicta_Sanctorum.Api.Controllers
{

    /// <summary>
    /// End-points voltados para as operações com as Frases dos Santos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PhraseController : ControllerBase
    {
        public List<string> listPhrases = ["A medida do amor é amar sem medida.", "O essencial não é pensar muito, é amar muito.", "A pessoa humana tem uma necessidade que é ainda mais profunda, uma fome que é maior que aquela que o pão pode saciar: é a fome que possui o coração humano da imensidade de Deus."];
        
        [HttpGet,Route("Random")]
        [EndpointDescription("Obtem uma Frase Aleatoriamente")]
        public async  Task<ActionResult<string>> GetRandom() { 
            
             Random random = new Random();
            int index=random.Next(this.listPhrases.Count());
            return Ok(this.listPhrases[index]);
        }

        [HttpGet, Route("{id}")]
        [EndpointDescription("Obtem uma Frase Pelo numero (Id) dela")]
        public async Task<ActionResult<string>> GetPhraseById(int id) {

            if (id < 1 || this.listPhrases.Count < id )
            {
                return BadRequest("Não encontramos uma frase com este Número");
            }
            
            return Ok(this.listPhrases[id-1]);
        
        }

        [HttpPost]
        [EndpointDescription("Adiciona uma Nova Frase")]
        public IActionResult CreateNewPhrase([FromBody] string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return BadRequest("a Frase está vazia e ela é obrigatória");
            }

            listPhrases.Add(phrase);
            return Ok("Frase adicionada com sucesso");

        }

        [HttpPut,Route("{id}")]
        [EndpointDescription("Atualiza Uma Frase")]
        public IActionResult UpdatePhrase(int id, string phrase)
        {
            if (id < 1 || this.listPhrases.Count < id)
            {
                return BadRequest("Não encontramos uma frase com este Número");
            }
            if (string.IsNullOrEmpty(phrase))
            {
                return BadRequest("a Frase está vazia e ela é obrigatória");
            }

             this.listPhrases[id-1]=phrase;

            return Ok("Frase atualizada com sucesso");
            
        }

        [HttpDelete, Route("{id}")]
        [EndpointDescription("Deleta Uma Frase")]
        public IActionResult DeletePhrase(int id) {
            if (id < 1 || this.listPhrases.Count < id)
            {
                return BadRequest("Não encontramos uma frase com este Número");
            }
            var itemToRemove=this.listPhrases[id-1];
            bool result=this.listPhrases.Remove(itemToRemove);
            if (result)
            {
                return Ok("Frase removida com sucesso");
            }
            else
            {
                return BadRequest("Houve um erro ao excluir a Frase");
            }
        }
    }
}
