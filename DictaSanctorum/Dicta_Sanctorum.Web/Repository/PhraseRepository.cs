using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Dicta_Sanctorum.Repository
{
    public class PhraseRepository
    {

        //Crud
        public PhraseRepository()
        {
            
        }

        public void Add(PhraseModel phrase)
        {
            var cntx = new EntityContext();
            cntx.Phrases.Add(phrase);
            cntx.SaveChanges();
        }

        public void Edit(PhraseModel phrase)
        {
            var cntx = new EntityContext();
            cntx.Phrases.Update(phrase);
            cntx.SaveChanges();
        }

        public void Delete(PhraseModel phrase)
        {
            var cntx = new EntityContext();
            cntx.Phrases.Remove(phrase);
            cntx.SaveChanges();
        }

        public List<PhraseModel> GetAll()
        {
            var cntx = new EntityContext();
            return cntx.Phrases.ToList();
        }

        public PhraseModel GetById(int id)
        {
            var cntx = new EntityContext();
            return cntx.Phrases.FirstOrDefault(s => s.id == id);
        }

    }
}
