

using Application.Commands;
using Application.Contracts;
using MediatR;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class SoftDeleteUserHandler : IRequestHandler<SoftDeleteUser, string>
    {


        private readonly IUnitOfWork _unitOfWork;

        public SoftDeleteUserHandler(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(SoftDeleteUser request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.UserRepository.SoftDeleteUserByIdRepository(request.Id);
        }


    }
}
