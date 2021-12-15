using CrudBlazor.Shared;
using System.ComponentModel;

namespace CrudBlazor.Client
{
    public interface IOsobaVM
    {
        public List<Osoba> Osobe { get;}
    }
    public class OsobaVM : IOsobaVM, INotifyPropertyChanged
    {
        private readonly IOsobaModel _osobaModel;
        public OsobaVM(IOsobaModel om)
        {
            _osobaModel = om;
        }

        public List<Osoba> Osobe => _osobaModel.Osobe is null ? new List<Osoba>() : _osobaModel.Osobe;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
