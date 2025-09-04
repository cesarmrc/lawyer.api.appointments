using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Meeting.GetById;

public class GetByIdMeetingQuery : IRequest<MeetingDto>
{
    public GetByIdMeetingQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
