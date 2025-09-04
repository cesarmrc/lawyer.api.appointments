using lawyer.api.appointments.domain.Common;

namespace lawyer.api.appointments.domain;

public class Meeting : BaseEntity
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdLead { get; set; }
    public DateTime Date { get; set; }
}
