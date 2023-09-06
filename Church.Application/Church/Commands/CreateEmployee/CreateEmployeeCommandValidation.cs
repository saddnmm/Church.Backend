using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Church.Application.Church.Commands.CreateEmployee
{
    public class CreateEmployeeCommandValidation : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidation()
        {
            RuleFor(createEmployeeCommand =>
                createEmployeeCommand.Employee_id).NotEqual(Guid.Empty);
            RuleFor(createEmployeeCommand =>
                createEmployeeCommand.Employee_name).NotEmpty().MaximumLength(250);
        }
    }
}
