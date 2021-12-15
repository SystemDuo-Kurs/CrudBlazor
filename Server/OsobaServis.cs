using CrudBlazor.Shared;

namespace CrudBlazor.Server
{
    public interface IOsobaServis
    {
        List<Osoba> GetAll();
        void Add(Osoba o);
    }

    public class OsobaServis : IOsobaServis
    {
        private readonly Db _db;

        public OsobaServis(Db db)
        {
            _db = db;
        }

        public List<Osoba> GetAll()
            => _db.Osobas.ToList();
        public void Add(Osoba o )
        {
            _db.Add(o);
            _db.SaveChanges();
        }
    }
}
