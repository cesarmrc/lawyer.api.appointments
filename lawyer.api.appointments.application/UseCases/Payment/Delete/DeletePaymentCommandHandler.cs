using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Payment;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Payment.Delete;

public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, Unit>
{
    private readonly IPaymentCommandRepository _command;
    private readonly IPaymentQueryRepository _query;

    public DeletePaymentCommandHandler(IPaymentCommandRepository command, IPaymentQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}

