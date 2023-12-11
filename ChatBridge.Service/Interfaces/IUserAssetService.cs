using Microsoft.AspNetCore.Http;
using ChatBridge.Service.Dtos.UserAssets;
using ChatBridge.Service.Configurations;

namespace ChatBridge.Service.Interfaces;

public interface IUserAssetService
{
    Task<bool> RemoveAsync(long userId, long id);
    Task<UserAssetForResultDto> RetrieveByIdAsync(long userId, long id);
    Task<UserAssetForResultDto> CreateAsync(IFormFile formFile);
    Task<IEnumerable<UserAssetForResultDto>> RetrieveAllAsync(long userId, PaginationParams @params);
}
