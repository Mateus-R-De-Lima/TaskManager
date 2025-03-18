using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetAll
{
    public class GetAllTasksUseCase
    {
       public ResponseAllTaskJson Execute()
        {
            return new ResponseAllTaskJson()
            {
                Tasks = new List<ResponseShotTask>()
                {
                    new ResponseShotTask
                    {
                        Id = Guid.NewGuid(),
                        Name = "Test",
                        Status = Communication.Enum.Status.in_Progress
                    }
                }
            };
        }
    }
}
