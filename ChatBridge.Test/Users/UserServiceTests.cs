using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ChatBridge.Data.IRepositories;
using ChatBridge.Domain.Entities;
using ChatBridge.Service.Dtos.Users;
using ChatBridge.Service.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

public class UserServiceTests
{
    [Fact]
    public async Task AddAsync_WhenUserDoesNotExist_ShouldReturnUserDto()
    {
        // Arrange
        var userRepositoryMock = new Mock<IRepository<User>>();
        var mapperMock = new Mock<IMapper>();

        var userService = new UserService(mapperMock.Object, userRepositoryMock.Object);

        var userForCreationDto = new UserForCreationDto
        {
            Email = "john.doe@example.com"
            // Add other necessary properties for testing
        };

        var existingUser = (User)null;

        // Mock UserRepository SelectAll method
        userRepositoryMock.Setup(repo => repo.SelectAll())
                         .Returns(new List<User>().AsQueryable());

        // Mock UserRepository SelectAll().Where() method
        userRepositoryMock.Setup(repo => repo.SelectAll().Where(It.IsAny<Expression<Func<User, bool>>>()))
                         .Returns(new List<User>().AsQueryable());

        // Mock UserRepository SelectAll().FirstOrDefaultAsync() method
        userRepositoryMock.Setup(repo => repo.SelectAll().FirstOrDefaultAsync(It.IsAny<CancellationToken>()))
                         .ReturnsAsync(existingUser);

        // Mock IMapper Map method
        var mappedUser = new User();
        mapperMock.Setup(mapper => mapper.Map<User>(userForCreationDto))
                  .Returns(mappedUser);

        // Mock UserRepository InsertAsync method
        var createdUser = new User(); // Provide necessary properties for testing
        userRepositoryMock.Setup(repo => repo.InsertAsync(It.IsAny<User>()))
                         .ReturnsAsync(createdUser);

        // Mock IMapper Map method for the result
        var createdUserDto = new UserForResultDto(); // Provide necessary properties for testing
        mapperMock.Setup(mapper => mapper.Map<UserForResultDto>(createdUser))
                  .Returns(createdUserDto);

        // Act
        var result = await userService.AddAsync(userForCreationDto);

        // Assert
        Assert.NotNull(result);
        Assert.Same(createdUserDto, result);

        // Verify that UserRepository methods were called as expected
        userRepositoryMock.Verify(repo => repo.SelectAll(), Times.Once);
        userRepositoryMock.Verify(repo => repo.SelectAll().Where(It.IsAny<Expression<Func<User, bool>>>()), Times.Once);
        userRepositoryMock.Verify(repo => repo.SelectAll().FirstOrDefaultAsync(It.IsAny<CancellationToken>()), Times.Once);
        userRepositoryMock.Verify(repo => repo.InsertAsync(It.IsAny<User>()), Times.Once);

        // Verify that Mapper methods were called as expected
        mapperMock.Verify(mapper => mapper.Map<User>(userForCreationDto), Times.Once);
        mapperMock.Verify(mapper => mapper.Map<UserForResultDto>(createdUser), Times.Once);
    }
}

// You'll need to replace IRepository, IMapper, UserForCreationDto, User, and UserForResultDto with your actual types.
