using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.GetAll;

public class GetAllPaymentQuery : IRequest<List<PaymentDto>>
{
}

