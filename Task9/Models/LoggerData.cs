using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task9.Models
{
    public class LoggerData
    {
        public string ActionName { get; set; }
        public DateTime ActionTime { get; set; }
        public string GetData()
        {
            return "[LOG]: " + ActionTime.ToString() + ": Action name - " + ActionName;
        }
    }
}
