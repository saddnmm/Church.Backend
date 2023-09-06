using MediatR;
using FluentValidation;

namespace Church.Application.Common.Behaviors
{
    public class ValidationBehavior<TRequest, TResponce>
        : IPipelineBehavior<TRequest, TResponce> where TRequest : IRequest<TResponce> 
    {
        private readonly IEnumerable<IValidator<TRequest>>  _validator;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validator)
        {
            _validator = validator;
        }
            

        public Task<TResponce> Handle(TRequest request,
             RequestHandlerDelegate<TResponce> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failure = _validator
                .Select(validator => validator.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(error => error != null)
                .ToList();
            if(failure.Count != 0)
            {
                throw new FluentValidation.ValidationException(failure);
            }

            return next();
        }       
    }
}
