using Gokart.Frontend.Clients;
using Gokart.Frontend.Components;
using Gokart.Frontend.Components.Pages;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents().AddCircuitOptions(options =>
{
    options.DetailedErrors = true;
    options.DisconnectedCircuitMaxRetained = 5;
});
builder.Logging.SetMinimumLevel(LogLevel.Debug);
builder.Services.AddServerSideBlazor(option => option.DetailedErrors = true);

var gameStoreApiUrl = builder.Configuration["GameStoreApiUrl"] ?? 
    throw new InvalidOperationException("GameStoreApiUrl configuration is missing.");
    
builder.Services.AddHttpClient<GokartokClient>(
    client => client.BaseAddress = new Uri(gameStoreApiUrl)
);
builder.Services.AddHttpClient<BerloClient>(
    client => client.BaseAddress = new Uri(gameStoreApiUrl)
);
builder.Services.AddHttpClient<BerlesClient>(
    client => client.BaseAddress = new Uri(gameStoreApiUrl)
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run() ;
