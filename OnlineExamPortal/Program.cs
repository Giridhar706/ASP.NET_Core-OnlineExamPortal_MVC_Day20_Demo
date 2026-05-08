using OnlineExamPortal.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add MVC with Global Filter
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<LoggingFilter>();
});

// Session Service
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});

builder.Services.AddDistributedMemoryCache();

builder.Services.AddScoped<LoggingFilter>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();