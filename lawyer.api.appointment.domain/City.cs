using lawyer.api.appointment.domain.Common;

namespace lawyer.api.appointment.domain;

public class City : BaseEntity
{
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
