using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Request
{
    public class RequestTaskJson
    {
        
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime Deadline { get; set; }
        public Priorities Priority { get; set; }

        public Status Status { get; set; }

    }
}
