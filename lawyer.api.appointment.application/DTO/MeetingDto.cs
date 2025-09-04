namespace lawyer.api.appointment.application.DTO;

public class MeetingDto
{
    public Guid Id { get; set; }
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdLead { get; set; }
    public DateTime Date { get; set; }
}
