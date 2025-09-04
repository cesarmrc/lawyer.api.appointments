using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointment.datastore.mssql.Model.Common;

namespace lawyer.api.appointment.datastore.mssql.Model;

[Table("Cities", Schema = "appointments")]
public class CityEntity : EFEntity
{
    public Guid IdCountry { get; set; }

    [ForeignKey(nameof(IdCountry))]
    public CountryEntity Country { get; set; }

    public string Name { get; set; }
}
