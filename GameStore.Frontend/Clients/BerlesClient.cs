using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class BerlesClient(HttpClient httpClient)
{    
    public async Task<BerlesSummary[]> GetBerlesAsync() => await httpClient.GetFromJsonAsync<BerlesSummary[]>("Berles") ?? [];

    public async Task AddBerlesAsync(BerlesDetails game) => await httpClient.PostAsJsonAsync("Berles", game);

    public async Task<BerlesDetails> GetBerlesAsync(int id) => 
        await httpClient.GetFromJsonAsync<BerlesDetails>($"Berles/{id}") 
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    /*public async Task UpdateBerlesAsync(GameDetails updatedGame) =>    
        await httpClient.PutAsJsonAsync($"Berles/{updatedGame.Id}", updatedGame);*/ 
    public async Task DeleteBerlesAsync(int id) =>    
        await httpClient.DeleteAsync($"Berles/{id}");    
}
