using AutoMapper;
using lawyer.api.appointments.application.DTO;
using lawyer.api.appointments.application.UseCases.Payment.Create;
using lawyer.api.appointments.application.UseCases.Payment.Update;
using lawyer.api.appointments.domain;

namespace lawyer.api.appointments.application.Common.MappingProfiles;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<PaymentDto, Payment>().ReverseMap();
        CreateMap<CreatePaymentCommand, Payment>().ReverseMap();
        CreateMap<UpdatePaymentCommand, Payment>().ReverseMap();
    }
}

