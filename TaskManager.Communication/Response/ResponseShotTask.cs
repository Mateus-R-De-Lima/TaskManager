using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Response
{
    public class ResponseShotTask
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Status Status { get; set; }

    }
}
