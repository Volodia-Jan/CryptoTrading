using CryptoTraiding.AccountManagment.AppStart;
using CryptoTraiding.AccountManagment.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDomain(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
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
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Traiding Account Management API V1");
    c.RoutePrefix = string.Empty;
});
app.MapControllers();

await app.AddMigration();

app.Run();