using lawyer.api.appointments.domain.Common;

namespace lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Common;

public interface ICommandRepository<T> where T : BaseEntity
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}