using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.GetAll;

public class GetAllSocialNetworkQuery : IRequest<List<SocialNetworkDto>>, IRequest<SocialNetworkDto>
{
}
