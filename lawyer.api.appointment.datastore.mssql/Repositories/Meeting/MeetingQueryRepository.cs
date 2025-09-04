using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.Meeting;

public class MeetingQueryRepository : QueryRepository<domain.Meeting, MeetingEntity>, IMeetingQueryRepository
{
    private readonly IMapper _mapper;

    public MeetingQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
