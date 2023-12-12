using FullTrailning.MiddleWare;
using FullTrailning.Option;
using FullTrailning.Prestence;
using FullTrailning.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<Config>(builder.Configuration.GetSection(nameof(Config)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));
builder.Services.AddTransient<IDiServices, DiServices>();

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
