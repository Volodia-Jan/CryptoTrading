using CryptoTrading.OrderManagement.AppStart;
using CryptoTrading.OrderManagement.Middleware;
using CryptoTraiding.OrderManagement.AppStart;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddDomain();
builder.Services.AddJwtAuthorization(builder.Configuration);
builder.Services.AddSwagger();

var app = builder.Build();

app.UseExceptionHandlerMiddleware();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trading Account Management API V1");
    c.RoutePrefix = string.Empty;
});
app.MapControllers();
await app.AddMigration();
app.Run();