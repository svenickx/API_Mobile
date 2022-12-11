using API_Mobile.Models;
using Newtonsoft.Json;
using System.Security.Principal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/people", () =>
{
    String JSONtxt = File.ReadAllText(@".\files\json\people.json");
    var people = JsonConvert.DeserializeObject<IEnumerable<People>>(JSONtxt);
    return people;
})
.WithName("GetPeople");

app.Run();
