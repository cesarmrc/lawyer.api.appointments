using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.GetById;

public class GetByIdSocialNetworkQuery : IRequest<SocialNetworkDto>
{
    public GetByIdSocialNetworkQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
