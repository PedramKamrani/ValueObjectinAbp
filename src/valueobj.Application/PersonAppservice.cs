
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using valueobj.Entites;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace valueobj
{
    public class PersonAppservice : CrudAppService<Person,PersonDto,Guid,
        PagedAndSortedResultRequestDto,CreatePerson>

    {
        public PersonAppservice(IRepository<Person, Guid> repository) :base(repository)
        {
                
        }
    }
}
