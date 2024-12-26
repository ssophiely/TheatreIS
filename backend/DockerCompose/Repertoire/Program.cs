using Repertoire.Clients;
using Repertoire.Storage;
using SharedUtils;
using StorageData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(builder.Configuration);

builder.Services.AddTransient<SpectaclesClient>();

builder.Services.AddScoped<TheatreDbContext>();

builder.Services.AddTransient<RepertoireStorage>();

builder.Services.AddTransient<ActStorage>();

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
