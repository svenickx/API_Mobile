using API_Mobile;
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


app.MapGet("/people/{page}", (int page) =>
{
    int nb = (page - 1) * 5;
    String JSONtxt = File.ReadAllText(@".\files\json\people.json");
    List<People> people = JsonConvert.DeserializeObject<List<People>>(JSONtxt)!;
    IEnumerable<People>? result = new List<People>();
    if (nb > people.Count - 1)
    {
        return result;
    }
    
    if (nb + 5 >= people.Count)
    {
        result = people.GetRange(nb, people.Count - nb - 1);
    } 
    else
    {
        result = people.GetRange(nb, 5);
    }
    return result;
})
.WithName("GetPeople");


app.MapGet("/person/{id}", (int id) =>
{
    String JSONtxt = File.ReadAllText(@".\files\json\people.json");
    List<People> people = JsonConvert.DeserializeObject<List<People>>(JSONtxt)!;
    People? result = people!.Where(p => p.Id == id).FirstOrDefault();
    if (result is null)
    {
        return new People();
    }
    return result;
})
.WithName("GetPerson");


app.Run();
