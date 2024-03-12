

using Application.Commands;
using Application.Contracts;
using Application.Services.Interface;
using MediatR;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class DeletePeopleHandler : IRequestHandler<DeletePeople, string>
    {

        private readonly IUnitOfWork _unitOfWork;

        public DeletePeopleHandler( IUnitOfWork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeletePeople request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.PeopleRepository.DeletePeopleById(request.Id);
        }
    }
}
