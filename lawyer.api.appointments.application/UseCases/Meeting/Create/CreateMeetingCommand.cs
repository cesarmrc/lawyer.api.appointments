using MediatR;

namespace lawyer.api.appointments.application.UseCases.Meeting.Create;

public class CreateMeetingCommand : IRequest<Guid>
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdLead { get; set; }
    public DateTime Date { get; set; }
}
