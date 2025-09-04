using lawyer.api.appointments.application.DTO;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Meeting.GetAll;

public class GetAllMeetingQuery : IRequest<List<MeetingDto>>
{
}
