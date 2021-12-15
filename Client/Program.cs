using CrudBlazor.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<SignalRComms>();
builder.Services.AddScoped<IOsobaModel, OsobaModel>();
builder.Services.AddScoped<IOsobaVM, OsobaVM>();



var app = builder.Build();
app.Services.GetService<SignalRComms>();

await app.RunAsync();
