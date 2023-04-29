using MeuLivroDeReceitas.Infrastructure.Migrations;
using MeuLivroDeReceitas.Domain.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

AtualizarDb();

app.Run();


void AtualizarDb()
{
    var con = builder.Configuration.GetConexao();
    var db = builder.Configuration.GetDatabase();
    Database.CriarDb(con, db);
}