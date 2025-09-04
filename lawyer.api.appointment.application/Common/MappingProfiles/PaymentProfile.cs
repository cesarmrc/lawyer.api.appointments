using AutoMapper;
using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.Payment.Create;
using lawyer.api.appointment.application.UseCases.Payment.Update;
using lawyer.api.appointment.domain;

namespace lawyer.api.appointment.application.Common.MappingProfiles;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<PaymentDto, Payment>().ReverseMap();
        CreateMap<CreatePaymentCommand, Payment>().ReverseMap();
        CreateMap<UpdatePaymentCommand, Payment>().ReverseMap();
    }
}

