using Spectacles.Storage;
using StorageData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<TheatreDbContext>();

builder.Services.AddTransient<EmpStorage>();

builder.Services.AddTransient<SpectacleStorage>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
