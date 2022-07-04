using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace valueobj
{
    public class PersonDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public AddressDto Address { get; set; }
    }
}
