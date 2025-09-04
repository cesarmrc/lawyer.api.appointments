using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;

public interface IMeetingCommandRepository : ICommandRepository<domain.Meeting>
{
}
