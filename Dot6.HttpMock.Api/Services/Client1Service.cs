using Dot6.HttpMock.Api.Models;

namespace Dot6.HttpMock.Api.Services;

public class Client1Service : IClient1Service
{
    private readonly HttpClient _httpClient;
    public Client1Service(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PublicApiContainer> Get()
    {
        return await _httpClient.GetFromJsonAsync<PublicApiContainer>("/entries");
    }
}

public interface IClient1Service
{
    public Task<PublicApiContainer> Get();
}