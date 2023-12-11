using ChatBridge.Service.Configurations.Filters;
using ChatBridge.Service.Configurations;
using ChatBridge.Service.Dtos.Users;
using ChatBridge.Domain.Entities;

namespace ChatBridge.Service.Interfaces;

public interface IUserService
{
    Task<bool> RemoveAsync(long id);
    Task<UserForResultDto> RetrieveByIdAsync(long id);
  //  Task<UserForResultDto> RetrieveByFilterAsync(GetFilter filter);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<UserForResultDto> AddAsync(UserForCreationDto dto);
    Task<UserForResultDto> RetrieveByEmailAsync(string email);
    Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
}
