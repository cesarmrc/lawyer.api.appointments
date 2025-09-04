using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.SocialNetwork;

public class SocialNetworkQueryRepository : QueryRepository<domain.SocialNetwork, SocialNetworkEntity>, ISocialNetworkQueryRepository
{
    private readonly IMapper _mapper;

    public SocialNetworkQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
