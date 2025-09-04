using lawyer.api.appointments.domain.Common;

namespace lawyer.api.appointments.domain;

public class City : BaseEntity
{
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
