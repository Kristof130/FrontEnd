using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class BerloClient(HttpClient httpClient)
{    
    public async Task<BerloSummary[]> GetGamesAsync() => await httpClient.GetFromJsonAsync<BerloSummary[]>("berlo") ?? [];

    public async Task AddGameAsync(GameDetails game) => await httpClient.PostAsJsonAsync("berlo", game);

    public async Task<GameDetails> GetGameAsync(int id) => 
        await httpClient.GetFromJsonAsync<GameDetails>($"berlo/{id}") 
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    public async Task UpdateGameAsync(GameDetails updatedGame) =>    
        await httpClient.PutAsJsonAsync($"berlo/{updatedGame.Id}", updatedGame);
    public async Task DeleteGameAsync(int id) =>    
        await httpClient.DeleteAsync($"berlo/{id}");    
}
