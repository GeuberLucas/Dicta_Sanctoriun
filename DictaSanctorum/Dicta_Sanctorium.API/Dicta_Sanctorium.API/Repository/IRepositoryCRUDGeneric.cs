using Dicta_Sanctorium.API.Domain;

namespace Dicta_Sanctorium.API.Repository
{
    public interface IRepositoryCRUDGeneric<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
    }
    
}
