using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Country.GetAll;

public class GetAllCountryQuery : IRequest<List<CountryQueryDto>>, IRequest<CountryQueryDto>
{
}
