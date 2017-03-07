using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace YourNamespace {
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddSession ();
            services.AddMvc ();
        }
        public void Configure (IApplicationBuilder App) {
            App.UseStaticFiles ();
            App.UseSession ();
            // Other Use statements
            App.UseMvc (); // That's it!
        }
    }
}