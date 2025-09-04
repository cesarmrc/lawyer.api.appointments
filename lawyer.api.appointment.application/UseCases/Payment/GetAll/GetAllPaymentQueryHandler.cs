using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Payment;
using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.GetAll;

public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQuery, List<PaymentDto>>
{
    private readonly IPaymentQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllPaymentQueryHandler(
        IMapper mapper,
        IPaymentQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<PaymentDto>> Handle(GetAllPaymentQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<PaymentDto>>(entities);
    }
}

