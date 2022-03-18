using Bics;
using Usmart.Client;

var builder = WebApplication.CreateBuilder(args);
BicsEngine.AddAssemblyNamePrefix("Lab");
builder.Services.AddUsmart();
builder.Services.AddBicsApi(builder.Configuration);
builder.Services.AddMemoryCache();
builder.Services.AddUsmartAuthentication(builder.Configuration);
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseBicsApi(builder =>
{
    builder.UseAuthentication().UseMiddleware<UsmartAuthorizationMiddleware>();
});
app.Run();
