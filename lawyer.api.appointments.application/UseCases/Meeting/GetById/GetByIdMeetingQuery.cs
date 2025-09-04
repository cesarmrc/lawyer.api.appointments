using lawyer.api.appointments.application.DTO;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Meeting.GetById;

public class GetByIdMeetingQuery : IRequest<MeetingDto>
{
    public GetByIdMeetingQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
