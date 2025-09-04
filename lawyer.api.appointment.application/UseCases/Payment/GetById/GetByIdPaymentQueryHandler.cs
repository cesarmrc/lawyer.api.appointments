using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Payment;
using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.GetById;

public class GetByIdPaymentQueryHandler : IRequestHandler<GetByIdPaymentQuery, PaymentDto>
{
    private readonly IPaymentQueryRepository _query;
    private readonly IMapper _mapper;

    public GetByIdPaymentQueryHandler(
        IMapper mapper,
        IPaymentQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<PaymentDto> Handle(GetByIdPaymentQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<PaymentDto>(entity);
    }
}

