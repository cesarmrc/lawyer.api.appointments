using MediatR;

namespace lawyer.api.appointment.application.UseCases.Country.Update;

public class UpdateCountryCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
