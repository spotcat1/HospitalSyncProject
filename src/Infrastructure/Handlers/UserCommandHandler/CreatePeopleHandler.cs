using Application.Commands;
using Application.Services.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class CreatePeopleHandler : IRequestHandler<CreatePeople, Guid>
    {
        private readonly IPeople _people;

        public CreatePeopleHandler(IPeople people)
        {
            _people = people;
        }

        public async Task<Guid> Handle(CreatePeople request, CancellationToken cancellationToken)
        {
            return await _people.AddPeople(request.dto);
        }
    }
}
