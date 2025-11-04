using PayrollWebApp.Repositories.Interface;
using PayrollWebApp.Repositories;
using PayrollWebApp.Services.Interface;
using PayrollWebApp.Services;
using PayrollWebApp.DataBaseConnection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbHelper>(sp =>
   new DbHelper(sp.GetRequiredService<IConfiguration>()));

//Allowance
builder.Services.AddTransient<IAllowanceRepository, AllowanceRepository>();
builder.Services.AddTransient<IAllowanceService, AllowanceService>();

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
