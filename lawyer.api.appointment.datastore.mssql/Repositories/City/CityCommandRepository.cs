using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.City;

public class CityCommandRepository : CommandRepository<domain.City, CityEntity>, ICityCommandRepository
{
    private readonly IMapper _mapper;

    public CityCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
