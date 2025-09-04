using AutoMapper;
using lawyer.api.appointments.application.DTO;
using lawyer.api.appointments.application.UseCases.Meeting.Create;
using lawyer.api.appointments.application.UseCases.Meeting.Update;
using lawyer.api.appointments.domain;

namespace lawyer.api.appointments.application.Common.MappingProfiles;

public class MeetingProfile : Profile
{
    public MeetingProfile()
    {
        CreateMap<MeetingDto, Meeting>().ReverseMap();
        CreateMap<CreateMeetingCommand, Meeting>().ReverseMap();
        CreateMap<UpdateMeetingCommand, Meeting>().ReverseMap();
    }
}
