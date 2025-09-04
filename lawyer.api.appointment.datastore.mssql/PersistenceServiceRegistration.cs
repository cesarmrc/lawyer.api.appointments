using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Payment;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model.MappingProfile;
using lawyer.api.appointment.datastore.mssql.Repositories.Example;
using lawyer.api.appointment.datastore.mssql.Repositories.Meeting;
using lawyer.api.appointment.datastore.mssql.Repositories.Payment;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lawyer.api.appointment.datastore.mssql;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<LawyersContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LawyersConnectionString")));
        services.AddAutoMapper(typeof(ApplicationMappingProfile).Assembly);
        services.AddScoped<IExampleCommandRepository, ExampleCommandRepository>();
        services.AddScoped<IExampleQueryRepository, ExampleQueryRepository>();
        services.AddScoped<IMeetingCommandRepository, MeetingCommandRepository>();
        services.AddScoped<IMeetingQueryRepository, MeetingQueryRepository>();
        services.AddScoped<IPaymentCommandRepository, PaymentCommandRepository>();
        services.AddScoped<IPaymentQueryRepository, PaymentQueryRepository>();

        return services;
    }
}