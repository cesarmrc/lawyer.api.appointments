using AutoMapper;
using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.SocialNetwork.Create;
using lawyer.api.appointment.application.UseCases.SocialNetwork.Update;
using lawyer.api.appointment.domain;

namespace lawyer.api.appointment.application.Common.MappingProfiles;

public class SocialNetworkProfile : Profile
{
    public SocialNetworkProfile()
    {
        CreateMap<SocialNetworkDto, SocialNetwork>().ReverseMap();
        CreateMap<CreateSocialNetworkCommand, SocialNetwork>().ReverseMap();
        CreateMap<UpdateSocialNetworkCommand, SocialNetwork>().ReverseMap();
    }
}
