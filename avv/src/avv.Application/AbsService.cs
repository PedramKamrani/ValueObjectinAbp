using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace avv
{
    public class AbsService: ApplicationService
    {
        private readonly IRepository<Ab, Guid> _repository;
        private readonly IIdentityRoleRepository _identityRoleRepository;

        public AbsService(IRepository<Ab, Guid> repository, IIdentityRoleRepository identityRoleRepository)
        {
            _repository = repository;
            _identityRoleRepository = identityRoleRepository;
        }
    }
}
