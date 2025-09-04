using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.Delete;

public class DeletePaymentCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}

