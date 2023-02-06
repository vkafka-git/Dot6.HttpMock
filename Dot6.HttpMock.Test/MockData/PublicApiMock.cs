using System.Collections.Generic;
using Dot6.HttpMock.Api.Models;

namespace Dot6.HttpMock.Test.MockData;

public class PublicApiMock
{
    public static PublicApiContainer Get()
    {
        return new PublicApiContainer
        {
            Count = 1,
            Entries = new List<PublicApi>
            {
                new PublicApi
                {
                    API = "AdoptAPet",
                    Description = "Resource to help get pets adopted",
                    Auth = "apiKey",
                    HTTPS = true,
                    Link = "https://www.adoptapet.com/public/apis/pet_list.html",
                    Category = "Animals"
                }
            }
        };
    }
}
