using MediatR;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Repository;
using WorldLeagure.Repository.Repositories;
using WorldLeagure.Repository.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddAutoMapper(typeof(Program));
//Add Services UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//Add Services Read And Write Repository
builder.Services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
builder.Services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
//Add Services to Custom Services

//Add Services to MediatR 
builder.Services.AddMediatR(typeof(Program));

//Add Services to DbContext
builder.Services.AddDbContext<WorldLeagueDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WorldLeague"), o =>
    {
        o.MigrationsAssembly("WorldLeagure.Repository");
    });
});


var app = builder.Build();

//Automatic operation of migration files in the database structure 
//using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
//{
//    var context = serviceScope.ServiceProvider.GetRequiredService<WorldLeagueDbContext>();
//    context.Database.Migrate();
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
