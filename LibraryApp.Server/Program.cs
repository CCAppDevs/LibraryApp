using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LibraryApp.Server.Data;
using LibraryApp.Server.Areas.Identity.Data;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("LibraryAppServerContextConnection") ?? throw new InvalidOperationException("Connection string 'LibraryAppServerContextConnection' not found.");

builder.Services.AddDbContext<LibraryAppServerContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<LibraryAppServerContext>();

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.MapFallbackToFile("/index.html");

app.Run();
