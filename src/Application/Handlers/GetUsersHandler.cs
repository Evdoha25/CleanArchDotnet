using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetUsersRequestHandler : IRequestHandler<GetUsersRequest, IEnumerable<UserDto>>
{
    private readonly IApplicationDbCotext _context;

    public GetUsersRequestHandler(IApplicationDbCotext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<UserDto>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
    {
        try
        {
        return await _context.Users
            .AsNoTracking()
            .Select(u => new UserDto
            {
                Id = u.Id,
                Name = u.Name
            })
            .ToListAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}