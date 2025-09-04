using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.City.GetAll;

public class GetAllCityQueryHandler : IRequestHandler<GetAllCityQuery, List<CityDto>>
{
    private readonly ICityQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllCityQueryHandler(
        IMapper mapper,
        ICityQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<CityDto>> Handle(GetAllCityQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<CityDto>>(entities);
    }
}
