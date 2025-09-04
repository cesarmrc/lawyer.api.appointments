using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.SocialNetwork;
using lawyer.api.appointment.application.Contracts.Interfaces.Persistence.Meeting;
using lawyer.api.appointment.datastore.mssql.DatabaseContext;
using lawyer.api.appointment.datastore.mssql.Model.MappingProfile;
using lawyer.api.appointment.datastore.mssql.Repositories.Example;
using lawyer.api.appointment.datastore.mssql.Repositories.City;
using lawyer.api.appointment.datastore.mssql.Repositories.Country;
using lawyer.api.appointment.datastore.mssql.Repositories.SocialNetwork;
using lawyer.api.appointment.datastore.mssql.Repositories.Meeting;
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
        services.AddScoped<ICityCommandRepository, CityCommandRepository>();
        services.AddScoped<ICityQueryRepository, CityQueryRepository>();
        services.AddScoped<ICountryCommandRepository, CountryCommandRepository>();
        services.AddScoped<ICountryQueryRepository, CountryQueryRepository>();
        services.AddScoped<ISocialNetworkCommandRepository, SocialNetworkCommandRepository>();
        services.AddScoped<ISocialNetworkQueryRepository, SocialNetworkQueryRepository>();
        services.AddScoped<IMeetingCommandRepository, MeetingCommandRepository>();
        services.AddScoped<IMeetingQueryRepository, MeetingQueryRepository>();

        return services;
    }
}