using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Repository
{
    public class SaintsRepository
    {

        public SaintsRepository()
        {
           
            
        }

        public void Add(SaintModel saint)
        {
            var cntx = new EntityContext();
            cntx.Saints.Add(saint);
            cntx.SaveChanges();
        }

        public int AddAndReturnId(SaintModel saint)
        {
            var cntx = new EntityContext();
            cntx.Saints.Add(saint);
            cntx.SaveChanges();
            return saint.id;
        }
        public void Edit(SaintModel saint)
        {
            var cntx = new EntityContext();
            cntx.Saints.Update(saint);
            cntx.SaveChanges();
        }

        public void Delete(SaintModel saint)
        {
            var cntx = new EntityContext();
            cntx.Saints.Remove(saint);
            cntx.SaveChanges();
        }

        public List<SaintModel> GetAll()
        {
            var cntx = new EntityContext();
            return cntx.Saints.ToList();
        }

        public SaintModel GetById(int id)
        {
            var cntx = new EntityContext();
            return cntx.Saints.FirstOrDefault(s => s.id == id);
        }
    }
}
