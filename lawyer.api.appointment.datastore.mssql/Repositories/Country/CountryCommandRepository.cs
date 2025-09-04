using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.Country;

public class CountryCommandRepository : CommandRepository<domain.Country, CountryEntity>, ICountryCommandRepository
{
    private readonly IMapper _mapper;

    public CountryCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
