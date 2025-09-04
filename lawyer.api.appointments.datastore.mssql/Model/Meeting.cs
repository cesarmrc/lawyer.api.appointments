using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointments.datastore.mssql.Model.Common;

namespace lawyer.api.appointments.datastore.mssql.Model;

[Table("Meetings", Schema = "appointments")]
public class MeetingEntity : EFEntity
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdLead { get; set; }
    public DateTime Date { get; set; }
}
