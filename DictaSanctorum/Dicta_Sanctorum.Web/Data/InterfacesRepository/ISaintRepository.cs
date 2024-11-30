using Dicta_Sanctorum.Models;

namespace Dicta_Sanctorum.Data.InterfacesRepository
{
    public interface ISaintRepository: IRepository<SaintModel>
    {
        int AddAndReturnId(SaintModel saintModel);
    }
}
