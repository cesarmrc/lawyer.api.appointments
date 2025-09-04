using AutoMapper;
using lawyer.api.appointments.application.Contracts.Interfaces.Persistence.Payment;
using lawyer.api.appointments.datastore.mssql.DatabaseContext;
using lawyer.api.appointments.datastore.mssql.Model;
using lawyer.api.appointments.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointments.datastore.mssql.Repositories.Payment;

public class PaymentCommandRepository : CommandRepository<domain.Payment, PaymentEntity>, IPaymentCommandRepository
{
    private readonly IMapper _mapper;

    public PaymentCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

