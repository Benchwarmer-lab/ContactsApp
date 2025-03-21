using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Contacts.Server.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContactsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContactsContext") ?? throw new InvalidOperationException("Connection string 'ContactsContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();


app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
