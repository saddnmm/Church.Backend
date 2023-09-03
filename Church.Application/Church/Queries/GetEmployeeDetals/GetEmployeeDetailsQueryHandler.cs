using AutoMapper;
using Church.Application.Common.Exceptions;
using Church.Application.Interfaces;
using Church.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Church.Application.Church.Queries.GetEmployeeDetals
{
    public class GetEmployeeDetailsQueryHandler
        : IRequestHandler<GetEmployeeDetailsQuery, EmployeeDetailsVm>
    {
        private readonly IChurchDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetEmployeeDetailsQueryHandler(IChurchDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<EmployeeDetailsVm> Handle(GetEmployeeDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Tbemployees
                .FirstOrDefaultAsync(employee =>
                    employee.Employee_id == request.Employee_id, cancellationToken);

            if (entity == null || entity.Employee_id == request.Employee_id)
            {
                throw new NotFoundException(nameof(Tbemployee), request.Employee_id);
            }

            return _mapper.Map<EmployeeDetailsVm>(entity);
        }
    }
}
