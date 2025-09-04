using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointments.datastore.mssql.Model.Common;

namespace lawyer.api.appointments.datastore.mssql.Model;

[Table("Examples", Schema = "appointments")]
public class ExampleEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string PropertyOne { get; set; }
    public string PropertyTwo { get; set; }
}
