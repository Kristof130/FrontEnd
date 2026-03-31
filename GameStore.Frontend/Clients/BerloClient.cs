using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class BerloClient(HttpClient httpClient)
{    
    public async Task<BerloSummary[]> GetBerlokAsync() => await httpClient.GetFromJsonAsync<BerloSummary[]>("berlo") ?? [];

    public async Task AddBerloAsync(BerloDetails berlo) => await httpClient.PostAsJsonAsync("berlo", berlo);

    public async Task<BerloDetails> GetBerloAsync(int id) => 
        await httpClient.GetFromJsonAsync<BerloDetails>($"berlo/{id}") 
        ?? throw new InvalidOperationException($"Berlo with ID {id} not found.");
    /*public async Task UpdateBerloAsync(GameDetails updatedGame) =>    
        await httpClient.PutAsJsonAsync($"berlo/{updatedGame.Id}", updatedGame);*/
    public async Task DeleteBerloAsync(int id) =>    
        await httpClient.DeleteAsync($"berlo/{id}");    
}
