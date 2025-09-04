using MediatR;

namespace lawyer.api.appointments.application.UseCases.Meeting.Delete;

public class DeleteMeetingCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
