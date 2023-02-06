using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dot6.HttpMock.Api.Models;
using Dot6.HttpMock.Api.Services;
using Dot6.HttpMock.Test.Helpers;
using Dot6.HttpMock.Test.MockData;
using Moq;
using Moq.Protected;
using Xunit;

namespace Dot6.HttpMock.Test.System.Services;

public class TestClient1Service
{
    [Fact]
    public async Task Get_ShouldReturnList()
    {
        /// Arrange
        var mockData = PublicApiMock.Get();
        var mockHandler = HttpClientHelper
        .GetResults<PublicApiContainer>(mockData);

        var mockHttpClient = new HttpClient(mockHandler.Object);
        mockHttpClient.BaseAddress = new Uri("https://api.publicapis.org");

        var client1Service = new Client1Service(mockHttpClient);

        /// Act
        var results = await client1Service.Get();

        /// Assert
        Assert.NotNull(results);

        mockHandler
        .Protected()
        .Verify(
            "SendAsync",
            Times.Exactly(1),
            ItExpr.Is<HttpRequestMessage>(
                req => req.Method == HttpMethod.Get &&
                req.RequestUri == new Uri("https://api.publicapis.org/entries")),
            ItExpr.IsAny<CancellationToken>()
        );
    }
}
