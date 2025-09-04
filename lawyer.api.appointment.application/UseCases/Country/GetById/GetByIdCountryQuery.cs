using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.Country.GetById;

public class GetByIdCountryQuery : IRequest<CountryQueryDto>
{
    public GetByIdCountryQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
