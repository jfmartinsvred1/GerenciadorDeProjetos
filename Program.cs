using Gerenciador.Authorization;
using Gerenciador.Data;
using Gerenciador.Data.EF;
using Gerenciador.Models;
using Gerenciador.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionStrings:Default"];

// Add services to the container.
builder.Services.AddDbContext<GerenciadorContext>(opts =>
{
    opts.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
});


builder.Services.AddIdentity<User,IdentityRole>()
    .AddEntityFrameworkStores<GerenciadorContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization(opts =>
{
    opts.AddPolicy("EmailConfirm" ,policy =>
    {
        policy.AddRequirements(new EmailConfirm(true));
    });
});

builder.Services.AddScoped<EmailService>();
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<IActivityDao, ActivityDao>();
builder.Services.AddScoped<IProjectUserDao, ProjectUserDao>();
builder.Services.AddScoped<IProjectDao, ProjectDao>();
builder.Services.AddScoped<IStateDao, StateDao>();
builder.Services.AddScoped<IUserDao, UserDao>();
builder.Services.AddSingleton<IAuthorizationHandler, EmailAuthorization>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(opts =>
{
    opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opts =>
{
    opts.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["SymmetricSecurityKey"])),
        ValidateAudience=false,
        ValidateIssuer= false,
        ClockSkew = TimeSpan.Zero
};
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
