using MediatR;

namespace lawyer.api.appointment.application.UseCases.Meeting.Delete;

public class DeleteMeetingCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
