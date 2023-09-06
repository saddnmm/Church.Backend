using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Commands.DeleteCommand
{
    public class DeleteEmployeeCommandValidator : AbstractValidator<DeleteEmployeeCommand>
    {
        public DeleteEmployeeCommandValidator()
        {
            RuleFor(deleteEmployeeCommand => deleteEmployeeCommand.Id)
                .NotEqual(Guid.Empty);
            RuleFor(deleteEmployeeCommand => deleteEmployeeCommand.RoleId)
                .NotEqual(Guid.Empty);
        }
    }
}
