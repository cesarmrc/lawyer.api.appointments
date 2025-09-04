using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.Meeting;

public class MeetingCommandRepository : CommandRepository<domain.Meeting, MeetingEntity>, IMeetingCommandRepository
{
    private readonly IMapper _mapper;

    public MeetingCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
