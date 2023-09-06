using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Queries.GetEmployeeList
{
    public class GetEmployeeListQueryValidator 
        : AbstractValidator<GetEmployeeListQuery>
    {
        public GetEmployeeListQueryValidator()
        {
            RuleFor(employee => employee.Employee_id).NotEqual(Guid.Empty);
        }
    }
}
