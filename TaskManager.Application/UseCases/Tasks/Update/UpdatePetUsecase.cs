using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.Update
{
    public class UpdatePetUsecase
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
