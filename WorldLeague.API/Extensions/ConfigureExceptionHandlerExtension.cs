using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Net.Mime;
using System.Text.Json;
using WorldLeague.API.Exceptions;
using WorldLeagure.Repository.Consts;

namespace WorldLeague.API.Extensions
{
    public static class ConfigureExceptionHandlerExtension
    {
        public static void ConfigureExceptionHandler<T>(this WebApplication webApplication, ILogger<T> logger)
        {
            webApplication.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError(contextFeature.Error.Message);
                        await context.Response.WriteAsync(JsonSerializer.Serialize(new ErrorException()
                        {
                            ErrorTitle = ErrorExceptionConst.ErrorTitle,
                            StatusCode = context.Response.StatusCode,
                            ErrorMessages = new List<string>() { contextFeature.Error.Message }
                        }));
                    }
                });
            });
        }
    }
}
