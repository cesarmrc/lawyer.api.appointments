using MediatR;

namespace lawyer.api.appointment.application.UseCases.City.Delete;

public class DeleteCityCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
