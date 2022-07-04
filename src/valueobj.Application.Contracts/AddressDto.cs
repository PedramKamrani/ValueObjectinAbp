using System;

namespace valueobj
{
    public class AddressDto 
    {
        public Guid CityId { get;  set; }

        public string Street { get;  set; }

        public int Number { get;  set; }
    }
    }
