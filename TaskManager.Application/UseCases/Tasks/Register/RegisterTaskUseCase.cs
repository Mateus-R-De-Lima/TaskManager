using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisterTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisterTaskJson
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
            };
        }
    }
}
