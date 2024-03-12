using Application.Commands;
using Application.Services.Interface;
using MediatR;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class UpdatePeopleHandler : IRequestHandler<UpdatePeople, string>
    {
        private readonly IPeople _people;

        public UpdatePeopleHandler(IPeople people)
        {
            _people = people;
        }

        public async Task<string> Handle(UpdatePeople request, CancellationToken cancellationToken)
        {
            return await _people.UpdatePeople( request.dto, request.Id);
        }
    }
}
