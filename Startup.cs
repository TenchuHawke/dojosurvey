using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace YourNamespace {
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();
        }
        public void Configure (IApplicationBuilder App) {

            App.UseStaticFiles ();
            // Other Use statements
            App.UseMvc (); // That's it!
        }
    }
}