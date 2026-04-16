using Gokart.Frontend.Models;

namespace Gokart.Frontend.Clients;

public class GokartokClient(HttpClient httpClient)
{    
    public async Task<GokartSummary[]> GetGokartokAsync() => await httpClient.GetFromJsonAsync<GokartSummary[]>("gokartok") ?? [];

    //public async Task AddGameAsync(GameDetails game) => await httpClient.PostAsJsonAsync("gokarts", game);

    public async Task<GokartDetails> GetGokartAsync(int id) => 
        await httpClient.GetFromJsonAsync<GokartDetails>($"gokartok/{id}") 
        ?? throw new InvalidOperationException($"Gokart with ID {id} not found.");
    public async Task UpdateGokartAsync(GokartDetails updatedGokart) =>    
        await httpClient.PutAsJsonAsync($"gokartok/{updatedGokart.Id}", updatedGokart);
    public async Task DeleteGokartAsync(int id) =>    
        await httpClient.DeleteAsync($"gokartok/{id}");    
}
