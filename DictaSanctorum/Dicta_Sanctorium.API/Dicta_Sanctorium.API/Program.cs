using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//Swagger config
builder.Services.AddSwaggerGen();


//Log config
builder.Host.UseSerilog((ctx, lc) =>
{
    lc.WriteTo.Console(LogEventLevel.Debug);
    lc.WriteTo.File("logs/log.txt",LogEventLevel.Warning,rollingInterval:RollingInterval.Day);
});

var app = builder.Build();

//swagger config
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
