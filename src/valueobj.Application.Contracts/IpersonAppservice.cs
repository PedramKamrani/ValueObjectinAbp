using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace valueobj
{
    public interface IPersonAppservice : ICrudAppService<PersonDto, Guid,
        PagedAndSortedResultRequestDto
        , CreatePerson>
    {

    }
}
