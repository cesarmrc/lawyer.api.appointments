using AutoMapper;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Payment;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model;
using lawyer.api.appointment.datastore.mssql.Repositories.Common;

namespace lawyer.api.appointment.datastore.mssql.Repositories.Payment;

public class PaymentCommandRepository : CommandRepository<domain.Payment, PaymentEntity>, IPaymentCommandRepository
{
    private readonly IMapper _mapper;

    public PaymentCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

