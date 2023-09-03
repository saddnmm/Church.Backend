using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Church.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Queries.GetEmployeeList
{
    public class GetEmployeeListQueryHandler
        : IRequestHandler<GetEmployeeListQuery, EmployeeListVm>
    {
        private readonly IChurchDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetEmployeeListQueryHandler(IChurchDbContext dbContext,
            IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<EmployeeListVm> Handle(GetEmployeeListQuery request,
            CancellationToken cancellationToken)
        {
            var notesQuery = await _dbContext.Tbemployees
                .Where(employee => employee.Employee_id == request.Employee_id)
                .ProjectTo<EmployeeLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new EmployeeListVm { Empoloyee = notesQuery };
        }

    }
}
