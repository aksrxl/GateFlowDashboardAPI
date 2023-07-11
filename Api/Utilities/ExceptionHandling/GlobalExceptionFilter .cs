using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GateFlowDashboardAPI.Utilities;

public class GlobalExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is InvalidOperationException invalidOperationException)
        {
            // Handling InvalidOperationException
            // Extracting the custom message from the exception
            string customMessage = invalidOperationException.Message;

            // Returning a BadRequest response with the custom message
            context.Result = new BadRequestObjectResult(new { message = "Invalid operation: " + customMessage });
        }
        else
        {
            // Handling other exceptions
            // For example, logging the exception and returning an InternalServerError response

            context.Result = new ObjectResult("An error occurred.")
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
        }
        context.ExceptionHandled = true;
    }
}


internal class ErrorResponse : ModelStateDictionary
{
    public string Message { get; set; }
}