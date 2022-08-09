using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace Task9.Models
{
    public class Logger : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var data = new LoggerData()
            {
                ActionName = context.ActionDescriptor.DisplayName,
                ActionTime = DateTime.Now
            };


            using (StreamWriter st = new StreamWriter("AppData/log.txt", true))
            {
                st.WriteLine(data.GetData());
            }
        }

    }
}
