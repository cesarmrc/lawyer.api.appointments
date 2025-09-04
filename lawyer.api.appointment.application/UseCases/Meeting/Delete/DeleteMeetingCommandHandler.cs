using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Meeting.Delete;

public class DeleteMeetingCommandHandler : IRequestHandler<DeleteMeetingCommand, Unit>
{
    private readonly IMeetingCommandRepository _command;
    private readonly IMeetingQueryRepository _query;

    public DeleteMeetingCommandHandler(IMeetingCommandRepository command, IMeetingQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteMeetingCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
