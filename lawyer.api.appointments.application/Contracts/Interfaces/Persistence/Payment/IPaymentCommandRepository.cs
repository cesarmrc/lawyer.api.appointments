using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Payment;

public interface IPaymentCommandRepository : ICommandRepository<domain.Payment>
{
}

