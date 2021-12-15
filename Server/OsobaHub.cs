using CrudBlazor.Shared;
using Microsoft.AspNetCore.SignalR;

namespace CrudBlazor.Server
{
    public class OsobaHub : Hub
    {
        private readonly ILogger _logger;
        private readonly IOsobaServis _os;
        public OsobaHub(IOsobaServis os, ILogger<OsobaHub> log)
        {
            _logger = log;
            _os = os;
        }
        public void Dodaj(Osoba o)
        {
            _logger.LogInformation($"Od klijenta -- {o.Name} - {o.Surname}");
            _os.Add(o);
        }

        public async void Posalji()
        {
            _logger.LogInformation("Klijent hoce gomilu osoba :)");

            await Clients.Caller.SendAsync("posalji", _os.GetAll());
        }
    }
}
