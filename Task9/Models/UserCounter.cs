using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Task9.Models
{
    public class UserCounter: ActionFilterAttribute
    {
        Counter counter;
        public UserCounter(Counter counter)
        {
            this.counter = counter;
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
        
            if (!Counter.guids.Contains(context.HttpContext.Session.Id))
            {
                Counter.guids.Add(context.HttpContext.Session.Id);
                Debug.Print("Session Counter: " + Counter.guids.Count);
            }
        }
    }
}
