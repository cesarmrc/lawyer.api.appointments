using AutoMapper;
using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointments.datastore.mssql.DatabaseContext;
using lawyer.api.appointments.datastore.mssql.Model;
using lawyer.api.appointments.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointments.datastore.mssql.Repositories.Meeting;

public class MeetingCommandRepository : CommandRepository<domain.Meeting, MeetingEntity>, IMeetingCommandRepository
{
    private readonly IMapper _mapper;

    public MeetingCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
