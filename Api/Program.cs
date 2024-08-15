using  Api.Infrastructure;
using Api.Endpoints.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebServices();

builder.Services.AddCors(options => { options.AddPolicy("corsapp", policy => { policy
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});


var app = builder.Build();

app.MapEndpoints();
app.UseEndpointDefinitions();
app.UseCors("corsapp");

app.UseHttpsRedirection();

app.Run();
