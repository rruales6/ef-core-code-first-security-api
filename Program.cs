using AltusERP_DB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//pgsql connection change as desired using COnfiguration sql server conection for ex
builder.Services.AddDbContext<AltusContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("AltusConnection")));

var app = builder.Build();
//create db if not exists 
using (var scope =app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AltusContext>();
    context.Database.EnsureCreated();
}
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
