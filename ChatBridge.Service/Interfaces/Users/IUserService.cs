using ChatBridge.Service.Configurations;
using ChatBridge.Service.Configurations.Filters;
using ChatBridge.Service.Dtos.Users;

namespace ChatBridge.Service.Interfaces.Users;

public interface IUserService
{
    Task<bool> RemoveAsync(long id);
    Task<UserForResultDto> RetrieveByIdAsync(long id);
    Task<UserForResultDto> AddAsync(UserForCreationDto dto);
    Task<UserForResultDto> RetrieveByFilterAsync(GetFilter filter);
    Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
  //  Task<bool> ChangePasswordAsync(long id, UserForChangePasswordDto dto);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
