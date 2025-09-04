using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Payment;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Payment.Create;

public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Guid>
{
    private readonly IPaymentCommandRepository _command;
    private readonly IMapper _mapper;

    public CreatePaymentCommandHandler(
        IPaymentCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.Payment>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}

