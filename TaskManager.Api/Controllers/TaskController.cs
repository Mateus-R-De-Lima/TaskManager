using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.GetById;
using TaskManager.Application.UseCases.Tasks.Register;
using TaskManager.Application.UseCases.Tasks.Update;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTaskJson request)
        {
            var useCase = new RegisterTaskUseCase();

            var response = useCase.Execute(request);

            return Created("", response);

        }


        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]

        public IActionResult Update([FromRoute] Guid id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();
            useCase.Execute(request);

            return NoContent();
        }


        [HttpGet]        
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTasksUseCase();
            var response = useCase.Execute();
            if (response.Tasks.Any())
            {
                return Ok(response);
            }

            return NoContent();

        }


        [HttpGet("{id}")]

        public IActionResult GetById(Guid id)
        {
            var useCase = new GetByIdTaskUseCase();
            var response = useCase.Execute(id);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]

        public IActionResult Delete([FromRoute] Guid id)
        {
            var useCase = new DeleteTaskByIdUseCase();
            useCase.Execute(id);
            return NoContent();
        }


    }
}
