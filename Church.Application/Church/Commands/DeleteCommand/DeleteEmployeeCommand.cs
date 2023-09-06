using MediatR;

namespace Church.Application.Church.Commands.DeleteCommand
{
    public class DeleteEmployeeCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public string Name { get; set; } 
    }
}
