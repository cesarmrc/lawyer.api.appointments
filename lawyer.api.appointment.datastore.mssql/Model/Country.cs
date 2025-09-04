using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointment.datastore.mssql.Model.Common;

namespace lawyer.api.appointment.datastore.mssql.Model;

[Table("Countries", Schema = "appointments")]
public class CountryEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Name { get; set; }

    public ICollection<CityEntity> Cities { get; set; } = new List<CityEntity>();
}
