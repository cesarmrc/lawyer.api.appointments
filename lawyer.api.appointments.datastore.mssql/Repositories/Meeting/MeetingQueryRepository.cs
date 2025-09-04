using AutoMapper;
using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointments.datastore.mssql.DatabaseContext;
using lawyer.api.appointments.datastore.mssql.Model;
using lawyer.api.appointments.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointments.datastore.mssql.Repositories.Meeting;

public class MeetingQueryRepository : QueryRepository<domain.Meeting, MeetingEntity>, IMeetingQueryRepository
{
    private readonly IMapper _mapper;

    public MeetingQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
