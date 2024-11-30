using Dicta_Sanctorum.Data.InterfacesRepository;
using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Data.Repository
{
    public class SaintsRepository: ISaintRepository
    {
        private readonly EntityContext _db;

        public SaintsRepository(EntityContext db)
        {
            _db = db;
        }

        public void Add(SaintModel saint)
        {

            _db.Saints.Add(saint);
            _db.SaveChanges();
        }

        public int AddAndReturnId(SaintModel saint)
        {

            _db.Saints.Add(saint);
            _db.SaveChanges();
            return saint.id;
        }
        public void Edit(SaintModel saint)
        {

            _db.Saints.Update(saint);
            _db.SaveChanges();
        }

        public void Delete(SaintModel saint)
        {

            _db.Saints.Remove(saint);
            _db.SaveChanges();
        }

        public List<SaintModel> GetAll()
        {

            return _db.Saints.ToList();
        }

        public SaintModel GetById(int id)
        {

            return _db.Saints.FirstOrDefault(s => s.id == id);
        }
    }
}
