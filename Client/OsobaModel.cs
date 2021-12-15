using CrudBlazor.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace CrudBlazor.Client
{
    public interface IOsobaModel
    {
        public List<Osoba> Osobe { get; set; }
    }
    public class OsobaModel : IOsobaModel
    {
        private readonly SignalRComms _sr;
        public OsobaModel(SignalRComms sr)
        {
            _sr = sr;
            _sr.PosaljiOsobe += Dohvati;
            
        }

        private List<Osoba> _osobe;
        public List<Osoba> Osobe
        {
            get
            {
                if (_osobe is null)
                {
                    _sr.Dohvati();
                    return _osobe;
                }
                else
                   return _osobe;
            }
            set => _osobe = value;
        }

        private void Dohvati(List<Osoba> o)
        {
            _osobe = o;
        }
    }
}
