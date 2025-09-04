using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.Update;

public class UpdatePaymentCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdMeeting { get; set; }
    public decimal Value { get; set; }
    public string State { get; set; } = string.Empty;
}

