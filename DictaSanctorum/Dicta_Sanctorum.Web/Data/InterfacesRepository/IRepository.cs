namespace Dicta_Sanctorum.Data.InterfacesRepository
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity model);
        void Edit(TEntity model);
        void Delete(TEntity model);
        List<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
