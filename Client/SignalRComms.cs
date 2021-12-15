using CrudBlazor.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace CrudBlazor.Client
{
    public class SignalRComms
    {
        private HubConnection _hc;
        public Action<List<Osoba>> PosaljiOsobe;

        public SignalRComms(NavigationManager nm)
        {
            _hc = new HubConnectionBuilder()
                .WithUrl(nm.BaseUri + "osobe")
                .Build();
            _hc.On<List<Osoba>>("posalji", osobe => PosaljiOsobe?.Invoke(osobe));
            Start();
        }

        public async void Dohvati()
        {
            await _hc.SendAsync("Posalji");
        }


        public async void Start()
        {
            await _hc.StartAsync();
        }
    }
}
