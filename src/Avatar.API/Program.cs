using Microsoft.EntityFrameworkCore;
using Share.Application.Abstractions.UnitOfWork;
using Share.Infrastructure.Data;
using Share.Infrastructure.Data.Seeders;
using Share.Infrastructure.Extensions;
using Share.Infrastructure.Implements.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add DbContext
//1. Fixed way
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//2. Flexible way
builder.Services.AddInfrastructureServices(builder.Configuration);

//Config CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//DataSeeder
var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<IDataSeeder>();
await seeder.InitSeedDataAsync();

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
