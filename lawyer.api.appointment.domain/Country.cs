using System.Collections.Generic;
using lawyer.api.appointment.domain.Common;

namespace lawyer.api.appointment.domain;

public class Country : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public List<City> Cities { get; set; } = new();
}
