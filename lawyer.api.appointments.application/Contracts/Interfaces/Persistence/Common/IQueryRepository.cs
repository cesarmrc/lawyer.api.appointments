using lawyer.api.appointments.domain.Common;

namespace lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Common;

public interface IQueryRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(Guid id, params string[] includes);
    Task<List<T>> GetAllAsync(params string[] includes);
}