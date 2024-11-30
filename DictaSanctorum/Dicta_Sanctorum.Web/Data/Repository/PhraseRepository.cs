using Dicta_Sanctorum.Data.InterfacesRepository;
using Dicta_Sanctorum.Entity;
using Dicta_Sanctorum.Models;
using Microsoft.EntityFrameworkCore;

namespace Dicta_Sanctorum.Data.Repository
{
    public class PhraseRepository:IPhraseRepository
    {
        private readonly EntityContext _db;

        //Crud
        public PhraseRepository(EntityContext db)
        {
            _db = db;
        }

        public void Add(PhraseModel phrase)
        {

            _db.Phrases.Add(phrase);
            _db.SaveChanges();
        }

        public void Edit(PhraseModel phrase)
        {

            _db.Phrases.Update(phrase);
            _db.SaveChanges();
        }

        public void Delete(PhraseModel phrase)
        {

            _db.Phrases.Remove(phrase);
            _db.SaveChanges();
        }

        public List<PhraseModel> GetAll()
        {

            return _db.Phrases.ToList();
        }

        public PhraseModel GetById(int id)
        {
            var phrase = _db.Phrases.FirstOrDefault(s => s.id == id);
            if (phrase == null)
            {
                throw new InvalidDataException("Frase não Encontrada");
            }
            return phrase;
        }

        public PhraseModel GetRandomPhrase()
        {
            var phrase= _db.Phrases.FromSqlRaw("SELECT * FROM Phrases\r\nORDER BY RAND()\r\nLIMIT 1").FirstOrDefault();
            return phrase;
        }
    }
}
