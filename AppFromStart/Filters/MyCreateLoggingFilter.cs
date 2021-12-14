using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Filters
{
    public class MyCreateLoggingFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action executed");
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine("Result executed");
        }
    }
}
