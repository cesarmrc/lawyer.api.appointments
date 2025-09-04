using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.SocialNetwork.GetById;

public class GetByIdSocialNetworkQueryHandler : IRequestHandler<GetByIdSocialNetworkQuery, SocialNetworkDto>
{
    private readonly IMapper _mapper;
    private readonly ISocialNetworkQueryRepository _query;

    public GetByIdSocialNetworkQueryHandler(
        IMapper mapper,
        ISocialNetworkQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<SocialNetworkDto> Handle(GetByIdSocialNetworkQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<SocialNetworkDto>(entity);
    }
}
