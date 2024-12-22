using Statistics;
using StorageData;
using SharedUtils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(builder.Configuration);

builder.Services.AddScoped<TheatreDbContext>();

builder.Services.AddTransient<StatisticsStorage>();

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
