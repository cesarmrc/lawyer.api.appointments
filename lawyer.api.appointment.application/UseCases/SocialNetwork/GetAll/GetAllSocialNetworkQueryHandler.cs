using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.GetAll;

public class GetAllSocialNetworkQueryHandler : IRequestHandler<GetAllSocialNetworkQuery, List<SocialNetworkDto>>
{
    private readonly ISocialNetworkQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllSocialNetworkQueryHandler(
        IMapper mapper,
        ISocialNetworkQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<SocialNetworkDto>> Handle(GetAllSocialNetworkQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<SocialNetworkDto>>(entities);
    }
}
