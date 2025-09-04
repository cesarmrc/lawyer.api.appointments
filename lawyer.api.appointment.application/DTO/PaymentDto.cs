namespace lawyer.api.appointment.application.DTO;

public class PaymentDto
{
    public Guid Id { get; set; }
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdMeeting { get; set; }
    public decimal Value { get; set; }
    public string State { get; set; }
}

