using AutoMapper;
using lawyer.api.appointments.application.DTO;
using lawyer.api.appointments.application.UseCases.Example.Create;
using lawyer.api.appointments.application.UseCases.Example.Update;
using lawyer.api.appointments.domain;

namespace lawyer.api.appointments.application.Common.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleDto, Example>().ReverseMap();
        CreateMap<CreateExampleCommand, Example>().ReverseMap();
        CreateMap<UpdateExampleCommand, Example>().ReverseMap();
    }
}
