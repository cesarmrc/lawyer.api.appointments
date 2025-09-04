using AutoMapper;
using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.City.Create;
using lawyer.api.appointment.application.UseCases.City.Update;
using lawyer.api.appointment.domain;

namespace lawyer.api.appointment.application.Common.MappingProfiles;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<CityDto, City>().ReverseMap();
        CreateMap<CreateCityCommand, City>().ReverseMap();
        CreateMap<UpdateCityCommand, City>().ReverseMap();
    }
}
