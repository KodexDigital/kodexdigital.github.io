using BlazorApp.Resume.My.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.Resume.My.Extensions
{
    public static class DependencyInjectionsExtension
    {
        public static IServiceCollection AddResumeServices(this IServiceCollection services)
        {
            services.AddTransient<LikeResumeService>();
            services.AddTransient<UserAuthenticationService>();

            return services;
        }
    }
}
