using AutoMapper;
using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.Country.Create;
using lawyer.api.appointment.application.UseCases.Country.Update;
using lawyer.api.appointment.domain;

namespace lawyer.api.appointment.application.Common.MappingProfiles;

public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<CountryDto, Country>().ReverseMap();
        CreateMap<CountryQueryDto, Country>().ReverseMap();
        CreateMap<CreateCountryCommand, Country>().ReverseMap();
        CreateMap<UpdateCountryCommand, Country>().ReverseMap();
    }
}
