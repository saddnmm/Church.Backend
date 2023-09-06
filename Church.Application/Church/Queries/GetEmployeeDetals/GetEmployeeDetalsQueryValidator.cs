using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Queries.GetEmployeeDetals
{
    public class GetEmployeeDetalsQueryValidator 
        : AbstractValidator<GetEmployeeDetailsQuery>

    {
        public GetEmployeeDetalsQueryValidator()
        {
            RuleFor(employee => employee.Employee_id).NotEqual(Guid.Empty);
        }
    }
}
