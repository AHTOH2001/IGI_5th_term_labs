using Igi_project.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Igi_project.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this
        IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}
