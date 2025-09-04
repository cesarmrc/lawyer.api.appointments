using lawyer.api.appointments.application.DTO;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Payment.GetById;

public class GetByIdPaymentQuery : IRequest<PaymentDto>
{
    public GetByIdPaymentQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}

