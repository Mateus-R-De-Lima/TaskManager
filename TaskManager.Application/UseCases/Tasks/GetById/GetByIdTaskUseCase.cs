using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetById
{
    public class GetByIdTaskUseCase
    {
        public ResponseTaskJson Execute(Guid id)
        {
            return new ResponseTaskJson
            {
                Id = id,
                Name = "Task",
                Description = "Description of task",
                Deadline = DateTime.UtcNow.AddDays(1),
                Priority = 0,
                Status = 0,
            };
        }
    }
}
