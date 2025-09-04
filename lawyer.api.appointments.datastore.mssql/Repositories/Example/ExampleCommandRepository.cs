using AutoMapper;
using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.appointments.datastore.mssql.DatabaseContext;
using lawyer.api.appointments.datastore.mssql.Model;
using lawyer.api.appointments.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointments.datastore.mssql.Repositories.Example;

public class ExampleCommandRepository : CommandRepository<domain.Example, ExampleEntity>, IExampleCommandRepository
{
    private readonly IMapper _mapper;

    public ExampleCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
