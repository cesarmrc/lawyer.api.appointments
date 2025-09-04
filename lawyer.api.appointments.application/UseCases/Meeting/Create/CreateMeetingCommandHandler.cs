using AutoMapper;
using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Meeting;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Meeting.Create;

public class CreateMeetingCommandHandler : IRequestHandler<CreateMeetingCommand, Guid>
{
    private readonly IMeetingCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateMeetingCommandHandler(
        IMeetingCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.Meeting>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
