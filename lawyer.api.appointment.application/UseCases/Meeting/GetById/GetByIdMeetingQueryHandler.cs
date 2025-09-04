using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Meeting.GetById;

public class GetByIdMeetingQueryHandler : IRequestHandler<GetByIdMeetingQuery, MeetingDto>
{
    private readonly IMapper _mapper;
    private readonly IMeetingQueryRepository _query;

    public GetByIdMeetingQueryHandler(
        IMapper mapper,
        IMeetingQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<MeetingDto> Handle(GetByIdMeetingQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<MeetingDto>(entity);
    }
}
