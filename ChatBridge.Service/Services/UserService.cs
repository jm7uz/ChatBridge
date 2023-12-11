using AutoMapper;
using ChatBridge.Domain.Entities;
using ChatBridge.Data.IRepositories;
using ChatBridge.Service.Dtos.Users;
using ChatBridge.Service.Exceptions;
using ChatBridge.Service.Extensions;
using ChatBridge.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using ChatBridge.Service.Configurations;

namespace ChatBridge.Service.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;
    private readonly IMapper _mapper;

    public UserService(IMapper mapper, IRepository<User> userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
    {
        var user =  await _userRepository.SelectAll()
        .Where(u => u.Email == dto.Email).FirstOrDefaultAsync();
        if (user is not null)
            throw new ChatBridgeException(409, "User already exsist");

        var mapUser =_mapper.Map<User>(dto);
        mapUser.CreateAt = DateTime.UtcNow;

        var createUser = await _userRepository.InsertAsync(mapUser);
        var a = _mapper.Map<UserForResultDto>(createUser);
        return a;
    }

    public async Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto)
    {
        var user = _userRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefault();
        if (user is null)
            throw new ChatBridgeException(404, "User not found");

        user.LastUpdatedAt = DateTime.UtcNow;
        var person = _mapper.Map(dto, user);
        await _userRepository.UpdateAsync(person);

        return _mapper.Map<UserForResultDto>(person);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = _userRepository.SelectByIdAsync(id);
        if (user is null)
            throw new ChatBridgeException(404, "User not found");

        return await _userRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var users = await _userRepository.SelectAll()
                //.Include(a => a.Assets)
                .AsNoTracking()
                .ToPagedList(@params)
                .ToListAsync();

        return _mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    public async Task<UserForResultDto> RetrieveByEmailAsync(string email)
    {
        var user = _userRepository.SelectAll()
            .Where(u => u.Email == email)
            //.Include(u => u.UserAssets)
            .AsNoTracking()
            .FirstOrDefault();
        if(user is null)
            throw new ChatBridgeException(404,$"User not found ");

        return  _mapper.Map<UserForResultDto>(user);
    }

    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await _userRepository.SelectAll()
                .Where(u => u.Id == id)
                //.Include(a => a.UserAssets)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        if (user is null)
            throw new ChatBridgeException(404, "User is not found");

        return _mapper.Map<UserForResultDto>(user);
    }
}
