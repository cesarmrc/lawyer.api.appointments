using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Payment;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Payment.Update;

public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, Guid>
{
    private readonly IPaymentCommandRepository _command;
    private readonly IPaymentQueryRepository _query;

    public UpdatePaymentCommandHandler(
        IPaymentCommandRepository command,
        IPaymentQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Guid> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) throw new KeyNotFoundException($"The payment with ID {request.Id} does not exist.");

        entity.IdUser = request.IdUser;
        entity.IdLawFirm = request.IdLawFirm;
        entity.IdMeeting = request.IdMeeting;
        entity.Value = request.Value;
        entity.State = request.State;
        entity.DateModified = DateTime.UtcNow;

        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}

