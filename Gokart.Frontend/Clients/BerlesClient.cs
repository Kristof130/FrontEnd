using Gokart.Frontend.Models;

namespace Gokart.Frontend.Clients;

public class BerlesClient(HttpClient httpClient)
{    
    public async Task<BerlesSummary[]> GetBerlesekAsync() => await httpClient.GetFromJsonAsync<BerlesSummary[]>("berles") ?? [];

    public async Task AddBerlesAsync(BerlesDetails Berles) => await httpClient.PostAsJsonAsync("berles", Berles);

    public async Task<BerlesDetails> GetBerlesAsync(int id) => 
        await httpClient.GetFromJsonAsync<BerlesDetails>($"berles/{id}") 
        ?? throw new InvalidOperationException($"Berles with ID {id} not found.");
    public async Task UpdateBerlesAsync(BerlesDetails updatedBerles) =>    
        await httpClient.PutAsJsonAsync($"berles/{updatedBerles.ID}", updatedBerles);
    public async Task DeleteBerlesAsync(int id) =>    
        await httpClient.DeleteAsync($"berles/{id}");    
}
