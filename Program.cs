using System.Reflection.Metadata.Ecma335;
using static System.Collections.Immutable.ImmutableArray;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

//routing
// "/tools"

app.MapGet("/tools", () =>
{
    return "Reading all the tools";

});

app.MapGet("/tool/{id}", (int id) =>
{
    return $"Reading shirt with ID:{id}";

});

app.MapPost("/tools", () =>
{
    return "creating a tool.";
});
app.MapPut("/tools/{id}", (int id) =>
{
    return $"Updating tools with ID:{id}";

});
app.MapDelete("/tools/{id}", (int id) =>
{
    return $"Deleting tolols with ID: {id}";


});
app.Run();

 