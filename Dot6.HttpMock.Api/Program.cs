using Dot6.HttpMock.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHttpClient<IClient1Service, Client1Service>(options =>
{
    options.BaseAddress = new Uri("https://api.publicapis.org");
});

builder.Services.AddHttpClient("publicAPI", options =>
{
    options.BaseAddress = new Uri("https://api.publicapis.org");
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
