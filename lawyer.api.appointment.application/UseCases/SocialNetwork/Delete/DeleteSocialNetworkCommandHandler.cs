using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.Delete;

public class DeleteSocialNetworkCommandHandler : IRequestHandler<DeleteSocialNetworkCommand, Unit>
{
    private readonly ISocialNetworkCommandRepository _command;
    private readonly ISocialNetworkQueryRepository _query;

    public DeleteSocialNetworkCommandHandler(
        ISocialNetworkCommandRepository command,
        ISocialNetworkQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteSocialNetworkCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
