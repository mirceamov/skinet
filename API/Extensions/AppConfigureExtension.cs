using Microsoft.AspNetCore.Builder;

namespace API.Extensions
{
    public static class AppConfigureExtension
    {
        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Skinet API v1");
            });

            return app;
        }
    }
}