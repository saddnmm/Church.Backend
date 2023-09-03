using Church.Application.Common.Exceptions;
using Church.Application.Interfaces;
using Church.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Church.Application.Church.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler
         : IRequestHandler<UpdateEmployeeCommand, Unit>
    {
        private readonly IChurchDbContext _dbContext;

        public UpdateEmployeeCommandHandler(IChurchDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.Tbemployees.FirstOrDefaultAsync(employee =>
                    employee.Employee_id == request.Employee_id, cancellationToken);

            if (entity == null || entity.Employee_id != request.Employee_id)
            {
                throw new NotFoundException(name: nameof(Tbemployee), request.Employee_id);
            }

            entity.Employee_id = request.Employee_id;
            entity.Employee_name = request.Employee_name;
            entity.Employee_surname = request.Employee_surname;
            entity.Employee_email = request.Employee_email;
            entity.Employee_phone = request.Employee_phone;
            entity.Employee_patronymic = request.Employee_patronymic;
            entity.Employee_description_about = request.Employee_description_about;
            entity.Employee_role_Id = request.Employee_role_Id;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
