using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(updateEmployeeCommand => updateEmployeeCommand.Employee_id).NotEqual(Guid.Empty);
            RuleFor(updateEmployeeCommand => updateEmployeeCommand.Employee_role_Id).NotEqual(Guid.Empty);
            RuleFor(updateEmployeeCommand => updateEmployeeCommand.Employee_name)
                .NotEmpty().MaximumLength(250);

        }
    }
}
