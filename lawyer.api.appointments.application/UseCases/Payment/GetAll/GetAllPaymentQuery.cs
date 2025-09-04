using lawyer.api.appointments.application.DTO;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Payment.GetAll;

public class GetAllPaymentQuery : IRequest<List<PaymentDto>>
{
}

