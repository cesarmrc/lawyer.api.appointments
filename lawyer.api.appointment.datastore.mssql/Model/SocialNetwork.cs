using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointment.datastore.mssql.Model.Common;

namespace lawyer.api.appointment.datastore.mssql.Model;

[Table("SocialNetworks", Schema = "appointments")]
public class SocialNetworkEntity : EFEntity
{
    public string Name { get; set; }
}
