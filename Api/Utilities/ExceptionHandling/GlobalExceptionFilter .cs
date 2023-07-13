namespace GateFlowDashboardAPI.Utilities
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Net;
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is InvalidOperationException invalidOperationException)
            {
                string customMessage = invalidOperationException.Message;
                context.Result = new BadRequestObjectResult(new { message = "Invalid operation: " + customMessage });
            }
            else
            {
                context.Result = new ObjectResult("An error occurred.")
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
            }
            context.ExceptionHandled = true;
        }
    }
}