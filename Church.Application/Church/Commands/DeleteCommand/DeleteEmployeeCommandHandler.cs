using Church.Application.Common.Exceptions;
using Church.Application.Interfaces;
using Church.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Commands.DeleteCommand
{
    internal class DeleteEmployeeCommandHandler
        : IRequestHandler<DeleteEmployeeCommand, Unit>
    {

        private readonly IChurchDbContext _dbContext;

        public DeleteEmployeeCommandHandler(IChurchDbContext dbContext) =>
            _dbContext = dbContext;
       

        public async Task<Unit> Handle(DeleteEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Tbemployees
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if(entity == null || entity.Employee_id != request.Id)
            {
                throw new NotFoundException(name: nameof(Tbemployee),
                    key: request.Id);
            }

            _dbContext.Tbemployees.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
