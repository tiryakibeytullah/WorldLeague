using MediatR;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Core;
using WorldLeague.API.Extensions;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Repository;
using WorldLeagure.Repository.Repositories;
using WorldLeagure.Repository.UnitOfWorks;
using WorldLeagure.Service.Filters;
using WorldLeagure.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
    .ConfigureApiBehaviorOptions(configuration => configuration.SuppressModelStateInvalidFilter = true);

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
builder.Services.AddScoped(typeof(ICountryService), typeof(CountryService));
builder.Services.AddScoped(typeof(IDrawReportService), typeof(DrawReportService));
builder.Services.AddScoped(typeof(IGroupService), typeof(GroupService));
builder.Services.AddScoped(typeof(ITeamService), typeof(TeamService));
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

//Add Serilog Configuration
Logger logConfiguration = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("WorldLeague"),
        "Logs",
        autoCreateSqlTable: true)
    .MinimumLevel.Information()
    .CreateLogger();
builder.Host.UseSerilog(logConfiguration);

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

//Add Global Error Handling Configuration
app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
