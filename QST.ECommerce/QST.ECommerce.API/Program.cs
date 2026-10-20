
using Microsoft.EntityFrameworkCore;
using QST.ECommerce.API;
using QST.ECommerce.Application;
using QST.ECommerce.Infrastructure.DbContexts;
using QST.ECommerce.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

var conStr = builder.Configuration.GetConnectionString("ECommerceDatabase");
// EF Core 
builder.Services.AddDbContext<CatalogDbContext>(
    options =>
    {
        options.UseMySql(conStr, ServerVersion.AutoDetect(conStr));
    });


//builder.Services.AddDbContext<OrderingDbContext>(
//    options =>
//    {
//        options.UseMySql(
//            connectingString,
//            ServerVersion.AutoDetect(connectingString));
//    });



// Add services to the container.

builder.Services.AddScoped<IProductService, ProductService>(); // Application Layer: This line will initialize Product Service which is inside Appliaction Layer
builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Infrastructure Layer

builder.Services.AddScoped<IDepartmentService, DepartmentService>(); // This line will intialize the Object of DepartmentService through Constructor Injection
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>(); // Infrastructure Layer

builder.Services.AddScoped<IBrandService, BrandService>(); // This line will intialize the Object of BrandService through Constructor Injection
builder.Services.AddScoped<IBrandRepository, BrandRepository>(); // Infrastructure Layer

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
