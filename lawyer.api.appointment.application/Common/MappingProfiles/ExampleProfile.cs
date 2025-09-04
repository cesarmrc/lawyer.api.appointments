using AutoMapper;
using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.Example.Create;
using lawyer.api.appointment.application.UseCases.Example.Update;
using lawyer.api.appointment.domain;

namespace lawyer.api.appointment.application.Common.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleDto, Example>().ReverseMap();
        CreateMap<CreateExampleCommand, Example>().ReverseMap();
        CreateMap<UpdateExampleCommand, Example>().ReverseMap();
    }
}
