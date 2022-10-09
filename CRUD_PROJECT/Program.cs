using CRUD_PROJECT.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//ContactsDb is a database name
//this line mainly to specify the controller called contactsAPiDbContext
builder.Services.AddDbContext<ContactsAPiDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("CRUD_PROJECTConnectionStrings")));
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
