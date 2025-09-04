using lawyer.api.appointments.application.DTO;
using MediatR;

namespace lawyer.api.appointments.application.UseCases.Example.GetAll;

public class GetAllExampleQuery : IRequest<List<ExampleDto>>, IRequest<ExampleDto>
{
}
