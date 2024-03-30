using Gerenciador.Data;
using Gerenciador.Data.EF;
using Gerenciador.Models;
using Gerenciador.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Default");

// Add services to the container.
builder.Services.AddDbContext<GerenciadorContext>(opts =>
{
    opts.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddIdentity<User,IdentityRole>()
    .AddEntityFrameworkStores<GerenciadorContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<IProjectUserDao, ProjectUserDao>();
builder.Services.AddScoped<IProjectDao, ProjectDao>();
builder.Services.AddScoped<IStateDao, StateDao>();
builder.Services.AddScoped<IUserDao, UserDao>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
