using Assignment2.Models;
using BussinessObjects;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;

var builder = WebApplication.CreateBuilder(args);

var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<MedicalFacility>("MedicalFacilities");
modelBuilder.EntitySet<ServicePriceList>("ServicePriceLists");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<MyDbContext>();

builder.Services.AddControllers().AddOData(
    options => options.Select().Filter().Count().OrderBy().Expand().SetMaxTop(100)
    .AddRouteComponents("odata", modelBuilder.GetEdmModel())
);

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

app.UseODataBatching();

app.Run();
