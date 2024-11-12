using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HelloBlazorApp.Data
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextFactory<PurchaseContext>(options =>
                options.UseNpgsql("Server=localhost;Port=5432;UserId=postgres;Database=Blazor;Password=123456;",
                    option => option.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution));
        }
        //    public void ConfigureServices(IServiceCollection services)
        //    {
        //        services.AddDbContext<PurchaseContext>(options =>
        //options.UseNpgsql("Server=localhost;Port=5432;UserId=postgres;Database=Blazor;Password=123456;"));
        //        services.AddDbContextFactory<PurchaseContext>(options =>
        //            options.UseNpgsql("Server=localhost;Port=5432;UserId=postgres;Database=Blazor;Password=123456;",
        //                option => option.CommandTimeout(60))
        //            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution));
        //        throw new NotImplementedException();
        //    }
    }
}