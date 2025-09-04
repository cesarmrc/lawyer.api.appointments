using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Meeting.Update;

public class UpdateMeetingCommandHandler : IRequestHandler<UpdateMeetingCommand, Guid>
{
    private readonly IMeetingCommandRepository _command;
    private readonly IMeetingQueryRepository _query;

    public UpdateMeetingCommandHandler(
        IMeetingCommandRepository command,
        IMeetingQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Guid> Handle(UpdateMeetingCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) throw new KeyNotFoundException($"The meeting with ID {request.Id} does not exist.");

        entity.IdUser = request.IdUser;
        entity.IdLawFirm = request.IdLawFirm;
        entity.IdLead = request.IdLead;
        entity.Date = request.Date;
        entity.DateModified = DateTime.UtcNow;

        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
