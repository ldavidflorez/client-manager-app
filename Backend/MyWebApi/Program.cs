using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using MyWebApi.Repository;
using MyWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add DB connection with EF
builder.Services.AddDbContext<ClientContext>(options =>
{
    options.UseNpgsql(Environment.GetEnvironmentVariable("ClientConnection"));
});

// Inject repository and client service
builder.Services.AddScoped<ICommonRepository<Client>, ClientRepository>();
builder.Services.AddScoped<ICommonService<Client, Client, Client>, ClientService>();

// Inject repository and user service (for authentication and autorization)
builder.Services.AddScoped<ICommonRepository<AppUser>, AppUserRepository>();
builder.Services.AddScoped<ICommonService<AppUser, AppUser, AppUser>, AppUserService>();

builder.Services.AddControllers();

// Secret key for sing JWT tokens
var secretKey = builder.Configuration.GetValue<string>("SecretKey");
// JWT Bearer token configuration
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey ?? string.Empty)),
        ValidateLifetime = true,
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero,
    };
});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();