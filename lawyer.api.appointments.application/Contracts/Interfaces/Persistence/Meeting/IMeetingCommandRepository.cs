using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Meeting;

public interface IMeetingCommandRepository : ICommandRepository<domain.Meeting>
{
}
