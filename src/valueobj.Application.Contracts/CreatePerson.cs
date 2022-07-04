using System;
using System.Collections.Generic;
using System.Text;

namespace valueobj
{
    public class CreatePerson
    {
        public string Name { get; set; }
        public AddressDto Address { get; set; }
    }
}
