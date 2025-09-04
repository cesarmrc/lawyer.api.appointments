using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.Example;

public class ExampleQueryRepository : QueryRepository<domain.Example, ExampleEntity>, IExampleQueryRepository
{
    private readonly IMapper _mapper;

    public ExampleQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
