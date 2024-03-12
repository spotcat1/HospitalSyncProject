

using FluentValidation;
using MediatR;

namespace Application.Behaviours.User
{
    public class PeopleValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {

        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public PeopleValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var Context = new ValidationContext<TRequest>(request);
                var ValidationResult = await Task.WhenAll(_validators.Select(x => x.ValidateAsync(Context, cancellationToken)));
                var Failure = ValidationResult.SelectMany(e=>e.Errors).Where(x=>x != null).ToList();
                if (Failure.Count != 0)
                {
                    throw new ValidationException(Failure);
                }
            }

            return await next();
        }
    }
}
