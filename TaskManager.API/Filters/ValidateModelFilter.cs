using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TaskManager.API.Filters;

public class ValidateModelFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            context.Result = new BadRequestObjectResult(new
            {
                success = false,
                message = "Validation failed",
                errors = context.ModelState
            });
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // No-op
    }
}
