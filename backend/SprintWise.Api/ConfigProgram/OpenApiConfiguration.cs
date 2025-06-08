using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SprintWise.Api.ConfigProgram
{
    public static class OpenApiConfiguration
    {

        public static IApplicationBuilder MapOpenApi(this IApplicationBuilder app)
        {
            //app.UseSwagger();
            //app.UseSwaggerUI();
            return app;
        }
    }
}
