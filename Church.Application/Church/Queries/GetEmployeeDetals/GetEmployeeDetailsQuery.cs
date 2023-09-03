using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Queries.GetEmployeeDetals
{
    public class GetEmployeeDetailsQuery : IRequest<EmployeeDetailsVm>
    {
        public Guid Employee_id { get; set; }
    }
}
