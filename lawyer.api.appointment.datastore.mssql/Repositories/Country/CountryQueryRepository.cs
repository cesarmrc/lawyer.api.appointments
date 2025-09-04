using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.Country;

public class CountryQueryRepository : QueryRepository<domain.Country, CountryEntity>, ICountryQueryRepository
{
    private readonly IMapper _mapper;

    public CountryQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
