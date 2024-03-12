

using Application.Commands;
using Application.Contracts;
using Application.Services.Interface;
using MediatR;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class DeleteUserHandler : IRequestHandler<DeleteUser, string>
    {

        private readonly IUnitOfWork _unitOfWork;

        public DeleteUserHandler( IUnitOfWork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeleteUser request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.UserRepository.DeleteUserByIdRepository(request.Id);
        }
    }
}
