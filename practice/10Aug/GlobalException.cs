using System.Text.Json;

namespace _10_Aug.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (ArgumentException ex)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.ContentType = "application/json";

                var response = new
                {
                    statusCode = 400,
                    message = ex.Message
                };

                await context.Response.WriteAsync(
                    JsonSerializer.Serialize(response));
            }
            catch (Exception ex)
            {
                context.Response.StatusCode =
                    StatusCodes.Status500InternalServerError;

                context.Response.ContentType = "application/json";

                var response = new
                {
                    statusCode = 500,
                    message = "Something went wrong"
                };

                await context.Response.WriteAsync(
                    JsonSerializer.Serialize(response));
            }
        }
    }
}
