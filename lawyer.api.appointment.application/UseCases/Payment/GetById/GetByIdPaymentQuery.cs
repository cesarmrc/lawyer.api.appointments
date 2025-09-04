using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.GetById;

public class GetByIdPaymentQuery : IRequest<PaymentDto>
{
    public GetByIdPaymentQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}

