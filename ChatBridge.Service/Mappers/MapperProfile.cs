using AutoMapper;
using ChatBridge.Domain.Entities;
using ChatBridge.Service.Dtos.Users;
using ChatBridge.Service.DTOs.MessageDTO;
using ChatBridge.Service.DTOs.UserAssetDTOs;

namespace ChatBridge.Service.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        // Message
       /* CreateMap<Message, MessageForUpdateDto>().ReverseMap();
        CreateMap<Message, MessageForCreationDto>().ReverseMap();
       */
        // User
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateRoleDto>().ReverseMap();
       // CreateMap<UserForCreationDto,UserAssetForResultDto>().ReverseMap();

        // UserAsset
        CreateMap<UserAsset, UserAssetForResultDto>().ReverseMap();

    }

}
