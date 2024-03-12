

using Application.Commands;
using Application.Contracts;
using MediatR;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class SoftDeletePeopleHandler : IRequestHandler<SoftDeletePeople, string>
    {


        private readonly IUnitOfWork _unitOfWork;

        public SoftDeletePeopleHandler(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(SoftDeletePeople request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.PeopleRepository.SoftDeletePeopleById(request.Id);
        }


    }
}
