using lawyer.api.appointment.domain.Common;

namespace lawyer.api.appointment.domain;

public class Payment : BaseEntity
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdMeeting { get; set; }
    public decimal Value { get; set; }
    public string State { get; set; } = string.Empty;
}

