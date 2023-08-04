using LocationHunter.Business.Abstract;
using LocationHunter.Business.Concrete;
using LocationHunter.DataAccess;
using LocationHunter.DataAccess.Abstract;
using LocationHunter.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(p => p.AddDefaultPolicy(policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddSingleton<IUserService,UserService>();
builder.Services.AddSingleton<IUserRepository,UserRepository>();

// Add services to the container

builder.Services.AddControllers();

// Register
//builder.Services.AddDbContext<UserDbContext>(options=>
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
//);

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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.Run();
