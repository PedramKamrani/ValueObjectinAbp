using Abp.Domain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueobj.Entites
{
    public class Address : ValueObject
    {
        public Guid CityId { get; private set; }

        public string Street { get; private set; }

        public int Number { get; private set; }

        private Address()
        {

        }

        public Address(
            Guid cityId,
            string street,
            int number)
        {
            CityId = cityId;
            Street = street;
            Number = number;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return CityId;
            yield return Number;
        }
    }
}
