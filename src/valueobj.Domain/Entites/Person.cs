using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace valueobj.Entites
{
    public class Person: AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
