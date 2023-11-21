using AutoMapper;
using ChatBridge.Domain.Entities;
using ChatBridge.Service.DTOs.MessageDTO;
using ChatBridge.Service.DTOs.UserAssetDTOs;
using ChatBridge.Service.DTOs.UserDTOs;

namespace ChatBridge.Service.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        // Message
        CreateMap<Message, MessageForUpdateDto>().ReverseMap();
        CreateMap<Message, MessageForCreationDto>().ReverseMap();

        // User
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForChangeRoleDto>().ReverseMap();
        CreateMap<User, UserForChangePasswordDto>().ReverseMap();

        // UserAsset
        CreateMap<UserAsset, UserAssetForResultDto>().ReverseMap();

    }

}
