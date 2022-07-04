using AutoMapper;
using valueobj.Entites;

namespace valueobj;

public class valueobjApplicationAutoMapperProfile : Profile
{
    public valueobjApplicationAutoMapperProfile()
    {

        CreateMap<Person,PersonDto>().ReverseMap();
        CreateMap<Person,CreatePerson>().ReverseMap();
        CreateMap<Address,AddressDto>().ReverseMap();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
