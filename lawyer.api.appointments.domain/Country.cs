using System.Collections.Generic;
using lawyer.api.appointments.domain.Common;

namespace lawyer.api.appointments.domain;

public class Country : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public List<City> Cities { get; set; } = new();
}
