using CrudBlazor.Shared;
using Microsoft.AspNetCore.SignalR;

namespace CrudBlazor.Server
{
    public class OsobaHub : Hub
    {
        private readonly ILogger _logger;
        private readonly Db _baza;
        public OsobaHub(Db baza, ILogger<OsobaHub> log)
        {
            _logger = log;
            _baza = baza;
        }
        public void Dodaj(Osoba o)
        {
            _logger.LogInformation($"Od klijenta -- {o.Name} - {o.Surname}");
            _baza.Add(o);
            _baza.SaveChanges();
        }

        public async void Posalji()
        {
            _logger.LogInformation("Klijent hoce gomilu osoba :)");

            await Clients.Caller.SendAsync("posalji", _baza.Osobas.ToList());
        }
    }
}
