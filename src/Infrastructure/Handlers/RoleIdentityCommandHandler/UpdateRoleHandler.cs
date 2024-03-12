using Application.Commands;
using Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Handlers.RoleIdentityCommandHandler
{
    public class UpdateRoleHandler : IRequestHandler<UpdateRole, string>
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public UpdateRoleHandler(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<string> Handle(UpdateRole request, CancellationToken cancellationToken)
        {

            var existingRole = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == request.id);

            if (existingRole != null)
            {
                existingRole.Name = request.dto.Name;

                var result = await _roleManager.UpdateAsync(existingRole);

                if (result.Succeeded)
                {
                    return "ویرایش با موفقیت انجام شد";
                }
                else
                {
                    return "خطا در ویرایش";
                }
            }

            throw new NotFoundException("شناسه نقش مورد نظر برای ویرایش یافت نشد");
        }
    }
}
