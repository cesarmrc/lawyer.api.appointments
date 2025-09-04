using lawyer.api.appointment.application.DTO;
using MediatR;

namespace lawyer.api.appointment.application.UseCases.City.GetById;

public class GetByIdCityQuery : IRequest<CityDto>
{
    public GetByIdCityQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
