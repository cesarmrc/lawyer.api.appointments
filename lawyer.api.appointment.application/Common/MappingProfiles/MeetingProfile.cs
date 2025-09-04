using AutoMapper;
using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.Meeting.Create;
using lawyer.api.appointment.application.UseCases.Meeting.Update;
using lawyer.api.appointment.domain;

namespace lawyer.api.appointment.application.Common.MappingProfiles;

public class MeetingProfile : Profile
{
    public MeetingProfile()
    {
        CreateMap<MeetingDto, Meeting>().ReverseMap();
        CreateMap<CreateMeetingCommand, Meeting>().ReverseMap();
        CreateMap<UpdateMeetingCommand, Meeting>().ReverseMap();
    }
}
