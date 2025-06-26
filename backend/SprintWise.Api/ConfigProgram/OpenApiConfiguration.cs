using Microsoft.OpenApi.Models;

namespace SprintWise.Api.ConfigProgram
{
    public static class OpenApiConfiguration
    {

        public static IServiceCollection AddOpenApiConfig(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SprintWise API",
                    Version = "v1",
                    Description = "Documentação da API do SprintWise"
                });

                //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                //{
                //    Name = "Authorization",
                //    Type = SecuritySchemeType.Http,
                //    Scheme = "Bearer",
                //    BearerFormat = "JWT",
                //    In = ParameterLocation.Header,
                //    Description = "Insira o token JWT no formato: Bearer {seu token}"
                //});

                //c.AddSecurityRequirement(new OpenApiSecurityRequirement
                //{
                //    {
                //        new OpenApiSecurityScheme
                //        {
                //            Reference = new OpenApiReference
                //            {
                //                Type = ReferenceType.SecurityScheme,
                //                Id = "Bearer"
                //            }
                //        },
                //        new string[] {}
                //    }
                //});

            });

            return services;
        }

        public static WebApplication MapOpenApi(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SprintWise API v1");
                c.RoutePrefix = "docs"; // Ex: https://localhost:5001/docs
            });

            return app;
        }
    }
}
