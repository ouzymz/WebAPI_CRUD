using System.Net.Http.Headers;
using BUSSINESLayer.Abstract;
using BUSSINESLayer.Concrete;
using DATALayer.Abstract;
using DATALayer.Concrete;
using DATALayer.EF;
using ENTITYLayer.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<StundentContext>(Opt =>
{
    Opt.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));

});
// Add services to the container.

builder.Services.AddScoped<IStundentDal, EFStudentDal>();
builder.Services.AddScoped<IStudentService, StudentManager>();

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

app.Run();
