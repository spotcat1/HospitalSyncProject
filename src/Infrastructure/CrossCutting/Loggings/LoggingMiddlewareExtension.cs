

using Microsoft.AspNetCore.Builder;

namespace Infrastructure.CrossCutting.Loggings
{
    public static class LoggingMiddlewareExtension
    {
        public static WebApplication UseLogging(this WebApplication app)
        {
            app.UseMiddleware<LoggingMiddleware>();
            return app;
        }
    }
}
