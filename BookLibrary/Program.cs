using BL.BussinessLogic.Services.Defenitions;
using BL.BussinessLogic.Services.Implementations;
using BL.DataAccess.Context;
using BL.DataAccess.Repositories.Defenitions;
using BL.DataAccess.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<BookLibContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("BookLibDb")
    ));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
