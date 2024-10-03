using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Models
{
    public class PhraseModel
    {
        public int id { get; set; }
        public int idSaint { get; set; }
        public string phrase { get; set; }

        public SaintModel Saint { get; set; }
    }
}
