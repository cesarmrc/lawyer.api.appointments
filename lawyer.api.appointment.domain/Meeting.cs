using lawyer.api.appointment.domain.Common;

namespace lawyer.api.appointment.domain;

public class Meeting : BaseEntity
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdLead { get; set; }
    public DateTime Date { get; set; }
}
