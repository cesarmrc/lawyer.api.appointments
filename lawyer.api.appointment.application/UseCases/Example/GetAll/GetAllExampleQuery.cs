using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Example.GetAll;

public class GetAllExampleQuery : IRequest<List<ExampleDto>>, IRequest<ExampleDto>
{
}
