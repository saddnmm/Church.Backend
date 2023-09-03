using Church.Application.Church.Queries.GetEmployeeDetals;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Queries.GetEmployeeList
{
    public class GetEmployeeListQuery : IRequest<EmployeeListVm>
    {
        public Guid Employee_id { get; set; }
    }
}
