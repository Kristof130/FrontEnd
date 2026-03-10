using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class BerloClient(HttpClient httpClient)
{    
    public async Task<BerloSummary[]> GetBerloAsync() => await httpClient.GetFromJsonAsync<BerloSummary[]>("berlo") ?? [];

    public async Task AddBerloAsync(BerloDetails game) => await httpClient.PostAsJsonAsync("berlo", game);

    public async Task<BerloDetails> GetBerloAsync(int id) => 
        await httpClient.GetFromJsonAsync<BerloDetails>($"berlo/{id}") 
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    /*public async Task UpdateBerloAsync(GameDetails updatedGame) =>    
        await httpClient.PutAsJsonAsync($"berlo/{updatedGame.Id}", updatedGame);*/
    public async Task DeleteBerloAsync(int id) =>    
        await httpClient.DeleteAsync($"berlo/{id}");    
}
