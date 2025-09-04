using MediatR;

namespace lawyer.api.appointment.application.UseCases.Example.Delete;

public class DeleteExampleCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
