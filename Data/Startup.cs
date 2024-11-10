using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace HelloBlazorApp.Data
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextFactory<PurchaseContext>(options => options.UseSqlServer("Server=localhost ; port=5432; user id=postgres; password=123456; database=Blazor;", 
                option => option.CommandTimeout(60)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution));
            throw new NotImplementedException();
        }
    }
}
