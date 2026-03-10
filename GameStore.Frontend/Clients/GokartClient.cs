using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GokartClient(HttpClient httpClient)
{    
    public async Task<GokartSummary[]> GetGamesAsync() => await httpClient.GetFromJsonAsync<GokartSummary[]>("gokarts") ?? [];

    //public async Task AddGameAsync(GameDetails game) => await httpClient.PostAsJsonAsync("gokarts", game);

    public async Task<GokartDetails> GetGameAsync(int id) => 
        await httpClient.GetFromJsonAsync<GokartDetails>($"gokarts/{id}") 
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    public async Task UpdateGokartAsync(GokartDetails updatedGokart) =>    
        await httpClient.PutAsJsonAsync($"gokarts/{updatedGokart.Id}", updatedGokart);
    public async Task DeleteGokartAsync(int id) =>    
        await httpClient.DeleteAsync($"gokarts/{id}");    
}
