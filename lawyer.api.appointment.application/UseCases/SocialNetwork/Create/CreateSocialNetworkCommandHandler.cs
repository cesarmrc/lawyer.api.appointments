using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.Create;

public class CreateSocialNetworkCommandHandler : IRequestHandler<CreateSocialNetworkCommand, Guid>
{
    private readonly ISocialNetworkCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateSocialNetworkCommandHandler(
        ISocialNetworkCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateSocialNetworkCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.SocialNetwork>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
