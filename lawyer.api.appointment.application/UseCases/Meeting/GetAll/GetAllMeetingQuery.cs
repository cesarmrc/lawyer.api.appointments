using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Meeting.GetAll;

public class GetAllMeetingQuery : IRequest<List<MeetingDto>>
{
}
