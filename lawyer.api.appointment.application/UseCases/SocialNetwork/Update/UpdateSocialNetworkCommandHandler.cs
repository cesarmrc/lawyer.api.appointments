using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.Update;

public class UpdateSocialNetworkCommandHandler : IRequestHandler<UpdateSocialNetworkCommand, Guid>
{
    private readonly ISocialNetworkCommandRepository _command;
    private readonly IMapper _mapper;

    public UpdateSocialNetworkCommandHandler(
        ISocialNetworkCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(UpdateSocialNetworkCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.SocialNetwork>(request);
        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
