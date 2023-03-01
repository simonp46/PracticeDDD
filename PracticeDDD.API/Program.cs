using Microsoft.EntityFrameworkCore;
using PracticeDDD.API.ApplicationServices;
using PracticeDDD.API.Queries;
using PracticeDDD.Domain.Repositories;
using PracticeDDD.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
});
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<PersonQueries>();
builder.Services.AddScoped<LiveServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
