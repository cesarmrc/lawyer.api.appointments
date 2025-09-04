using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.City.GetAll;

public class GetAllCityQuery : IRequest<List<CityDto>>, IRequest<CityDto>
{
}
