using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointment.datastore.mssql.Model.Common;

namespace lawyer.api.appointment.datastore.mssql.Model;

[Table("Examples", Schema = "appointments")]
public class ExampleEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string PropertyOne { get; set; }
    public string PropertyTwo { get; set; }
}
