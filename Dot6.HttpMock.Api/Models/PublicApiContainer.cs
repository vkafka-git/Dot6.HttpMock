using Dot6.HttpMock.Api.Models;

namespace Dot6.HttpMock.Api.Models
{
    public class PublicApiContainer
    {
        public int Count { get; set; }
        public List<PublicApi>? Entries { get; set; }
    }

    public class PublicApi
    {
        public string? API { get; set; }
        public string? Description { get; set; }
        public string? Auth { get; set; }
        public bool HTTPS { get; set; }
        public string? Link { get; set; }
        public string? Category { get; set; }
    }
}