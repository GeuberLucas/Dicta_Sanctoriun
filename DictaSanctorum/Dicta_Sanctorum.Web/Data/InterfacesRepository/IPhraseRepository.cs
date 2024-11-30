using Dicta_Sanctorum.Models;

namespace Dicta_Sanctorum.Data.InterfacesRepository
{
    public interface IPhraseRepository: IRepository<PhraseModel>
    {
        PhraseModel GetRandomPhrase();
    }
}
