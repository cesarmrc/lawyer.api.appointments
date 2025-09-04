using AutoMapper;
using lawyer.api.appointment.domain;
using lawyer.api.appointment.datastore.mssql.Model;

namespace lawyer.api.appointment.datastore.mssql.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Example, ExampleEntity>().ReverseMap();
        CreateMap<Meeting, MeetingEntity>().ReverseMap();
        CreateMap<Payment, PaymentEntity>().ReverseMap();
    }
}
