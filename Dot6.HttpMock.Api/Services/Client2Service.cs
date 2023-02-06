using Dot6.HttpMock.Api.Models;

namespace Dot6.HttpMock.Api.Services;

public class Client2Service : IClient2Service
{
    private readonly IHttpClientFactory _httpClientFactory;
    public Client2Service(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<PublicApiContainer> Get()
    {
        var httpclient = _httpClientFactory.CreateClient("publicAPI");
        return await httpclient.GetFromJsonAsync<PublicApiContainer>("/entries");
    }
}

public interface IClient2Service
{
    Task<PublicApiContainer> Get();
}