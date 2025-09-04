using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.Create;

public class CreatePaymentCommand : IRequest<Guid>
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdMeeting { get; set; }
    public decimal Value { get; set; }
    public string State { get; set; } = string.Empty;
}

