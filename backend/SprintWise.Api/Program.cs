using SprintWise.Api.ConfigProgram;
using SprintWise.Api.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApiConfig();
builder.Services.ConfigurePostgreDataBase(builder);

builder.Services.AddSignalR();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new UUIDJsonConverter());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(c => c.SetIsOriginAllowed(or => true).AllowAnyMethod().AllowAnyHeader().AllowCredentials().WithOrigins("http://localhost:4200"));

app.MapControllers();
app.MapHub<PlanningPokerNotificationHub>("/planningpokernotificationhub");

app.Run();



