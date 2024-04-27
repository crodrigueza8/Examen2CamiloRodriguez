using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Examen2CamiloRodriguez.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.All)]
    public sealed class ApikeyAttribute : Attribute, IAsyncActionFilter
    {
        private readonly string apiKey = "P6Apikey";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            

            if (!context.HttpContext.Request.Headers.TryGetValue(apiKey, out var ApiSalida))
            {
                
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "The http request doesn't contain security information"
                };
                return;
            }

        
            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            var ApiKeyValue = appSettings.GetValue<string>(apiKey);
            

            if (ApiKeyValue != null && !ApiKeyValue.Equals(ApiSalida))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Incorrect Apikey Data....."

                };
                return;
            }

            await next();

        }



    }
}
