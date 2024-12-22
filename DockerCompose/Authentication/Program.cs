using Authentication;
using StorageData;
using SharedUtils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(builder.Configuration);

builder.Services.AddScoped<TheatreDbContext>();
builder.Services.AddTransient<UserStorage>();

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


//dotnet ef dbcontext scaffold "server=localhost;database=theatre;user=root;password=root;" MySql.EntityFrameworkCore --output-dir ../StorageData/Storage/Models --context TheatreDbContext --context-dir ../StorageData/Storage/ --no-pluralize --force --namespace StorageData