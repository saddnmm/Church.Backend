using Church.Application.Interfaces;
using Church.Domain;
using MediatR;

namespace Church.Application.Church.Commands.CreateEmployee
{
    public class CreateEmployeeComandHandler :
        IRequestHandler<CreateEmployeeCommand, Guid>
    {
        private readonly IChurchDbContext _dbContext;

        public CreateEmployeeComandHandler(IChurchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateEmployeeCommand request,
            CancellationToken cancellationToken)
        {


            var employee = new Tbemployee
            {
                Employee_id = Guid.NewGuid(),
                Employee_name = request.Employee_name,
                Employee_surname = request.Employee_surname,
                Employee_patronymic = request.Employee_patronymic,
                Employee_email = request.Employee_email,
                Employee_phone = request.Employee_phone,
                Employee_description_about = request.Employee_description_about,
                Employee_role_Id = request.Employee_role_Id
            };

            await _dbContext.Tbemployees.AddAsync(employee, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return employee.Employee_id;
        }
    }
}
