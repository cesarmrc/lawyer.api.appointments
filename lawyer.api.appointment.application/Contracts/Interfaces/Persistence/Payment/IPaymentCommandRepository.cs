using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Payment;

public interface IPaymentCommandRepository : ICommandRepository<domain.Payment>
{
}

