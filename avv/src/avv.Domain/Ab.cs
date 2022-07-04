using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace avv
{
    public class Ab: AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Titled { get; set; }
    }
}
