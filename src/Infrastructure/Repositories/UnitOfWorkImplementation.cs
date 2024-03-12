using Application.Contracts;
using Infrastructure.Persistants;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWorkImplementation : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICacheManagerService _cacheManagerService;

        #region Repositories
        public IUserRepository UserRepository { get; private set; }
        #endregion
        public UnitOfWorkImplementation(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor contextAccessor, ICacheManagerService cacheManagerService)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _contextAccessor = contextAccessor;
            _cacheManagerService = cacheManagerService;
            UserRepository = new UserRepositoryImplementation(_webHostEnvironment, _contextAccessor, _context,_cacheManagerService);
        }


        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
