using ChatBridge.Service.Configurations.Paginations;
using ChatBridge.Service.Dtos.Users;

namespace ChatBridge.Service.Interfaces;

public interface IUserService
{
    Task<bool> RemoveAsync(long id);
    Task<UserForResultDto> RetrieveByIdAsync(long id);
    //Task<UserForResultDto> RetrieveByFilterAsync(GetFilter filter);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<UserForResultDto> AddAsync(UserForCreationDto dto);
    Task<UserForResultDto> RetrieveByEmailAsync(string email);
    Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
}
