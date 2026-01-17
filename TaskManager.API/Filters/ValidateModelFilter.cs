using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TaskManager.Application.Common;

namespace TaskManager.API.Filters;

public class ValidateModelFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            context.Result = new BadRequestObjectResult(
                ApiResponse<object>.Fail(
                    "Validation failed",
                    ErrorCodes.ValidationError
                )
                );
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // No-op
    }
}
