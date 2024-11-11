using GuideApp.WebApp.DbContexts;
using GuideApp.WebApp.Services;
using Microsoft.EntityFrameworkCore;

namespace GuideApp.WebApp;

internal static class StartupHelperExtensions
{
    // Add services to the container.
    public static WebApplication ConfigureServices(
        this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();

        builder.Services.AddScoped<IRepository, Repository>();

        builder.Services.AddDbContext<CompanyInfoContext>(options =>
        {
            string? dbType = builder.Configuration.GetSection("DbConnection:DbType").Get<string>();

            if (dbType == null)
            {
                options.UseSqlite(@"Data Source = library.db");
            }

            switch (dbType.ToLower())
            {
                case ("mssql"):
                    options.UseSqlServer(builder.Configuration
                        .GetConnectionString("DbConnection:DbType:ConnectionString"));
                    break;
                case("mssqlserver"):
                    options.UseSqlServer(builder.Configuration
                        .GetConnectionString("DbConnection:DbType:ConnectionString"));
                    break;
                case ("sqlite"):
                    options.UseSqlite(builder.Configuration
                        .GetConnectionString("DbConnection:DbType:ConnectionString"));
                    break;
                case ("postgresql"):
                    options.UseNpgsql(builder.Configuration
                        .GetConnectionString("DbConnection:DbType:ConnectionString"));
                    break;
                default:
                    options.UseSqlite(@"Data Source = library.db");
                    break;
            }
        });

        builder.Services.AddAutoMapper(
            AppDomain.CurrentDomain.GetAssemblies());
        
        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(
        this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        
        return app;
    }
}