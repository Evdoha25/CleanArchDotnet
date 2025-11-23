using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application.Tests;

public class GetUserCommandQueryTest
{
    [Fact]
    public async Task Handle_Valid_Command_Returns_UserDTO()
    {
        //using in memoryDatabase
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "TestDatabase")
        .Options;

        using var context = new ApplicationDbContext(options);

        //adding data
        var user = new User { Id = 1, Name="Bob" };
        context.Users.Add(user);
        await context.SaveChangesAsync(CancellationToken.None);

        var handler = new GetUsersRequestHandler(context);
        var query = new GetUsersRequest();

        var result = await handler.Handle(query, CancellationToken.None);

        Assert.NotNull(result);
        var resultList = result.ToList();
        Assert.Single(resultList);

        var userDto = result.First();
        Assert.Equal(1 , userDto.Id);
        Assert.Equal("Bob", userDto.Name);
    }
}
