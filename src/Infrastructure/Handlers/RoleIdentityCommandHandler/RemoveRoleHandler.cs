using Application.Commands;
using Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Infrastructure.Handlers.RoleIdentityCommandHandler
{
    public class RemoveRoleHandler : IRequestHandler<DeleteRole, string>
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public RemoveRoleHandler(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<string> Handle(DeleteRole request, CancellationToken cancellationToken)
        {
            var Role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == request.id);

            if (Role is null)
            {
                throw new NotFoundException("شناسه نقش مورد نظر برای حذف یافت نشد");
            }

            var Result = await _roleManager.DeleteAsync(Role);


            if (Result.Succeeded)
            {
                return "حذف نقش با موفقیت انجام شد";
            }
            else
            {
                return "خطا در حذف نقش";
            }
        }
    }
}
