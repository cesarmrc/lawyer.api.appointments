using AutoMapper;
using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointments.application.DTO;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Meeting.GetAll;

public class GetAllMeetingQueryHandler : IRequestHandler<GetAllMeetingQuery, List<MeetingDto>>
{
    private readonly IMeetingQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllMeetingQueryHandler(
        IMapper mapper,
        IMeetingQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<MeetingDto>> Handle(GetAllMeetingQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<MeetingDto>>(entities);
    }
}
