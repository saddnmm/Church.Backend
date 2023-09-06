using AutoMapper;
using Church.Application.Church.Commands.DeleteCommand;
using Church.Application.Church.Queries.GetEmployeeDetals;
using Church.Application.Church.Queries.GetEmployeeList;
using Church.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Church.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : BaseController
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task <ActionResult<EmployeeListVm>> GetAll()
        {
            var query = new GetEmployeeListQuery()
            {
                Employee_id = Employee_id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDetailsVm>> Get(Guid id)
        {
            var query = new GetEmployeeDetailsQuery
            {
                Employee_id = id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            var command = _mapper.Map<UpdateNoteDto>(createEmployeeDto);
            command.Employee_id = Employee_id;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> Update([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            var command = _mapper.Map<CreateEmployeeDto>(createEmployeeDto);
            command.Employee_id = Employee_id;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> Delete([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            var command = new DeleteEmployeeCommand
            {
                Id = Employee_id
            };

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
