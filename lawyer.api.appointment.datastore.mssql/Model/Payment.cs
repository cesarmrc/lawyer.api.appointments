using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.appointment.datastore.mssql.Model.Common;

namespace lawyer.api.appointment.datastore.mssql.Model;

[Table("Payments", Schema = "appointments")]
public class PaymentEntity : EFEntity
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdMeeting { get; set; }
    public decimal Value { get; set; }
    public string State { get; set; } = string.Empty;
}

