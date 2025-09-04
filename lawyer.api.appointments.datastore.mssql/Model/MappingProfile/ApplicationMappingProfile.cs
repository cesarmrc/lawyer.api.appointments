using AutoMapper;
using lawyer.api.appointments.domain;
using lawyer.api.appointments.datastore.mssql.Model;

namespace lawyer.api.appointments.datastore.mssql.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Example, ExampleEntity>().ReverseMap();
        CreateMap<Meeting, MeetingEntity>().ReverseMap();
        CreateMap<Payment, PaymentEntity>().ReverseMap();
    }
}
