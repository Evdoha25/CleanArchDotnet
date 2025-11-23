using MediatR;

public class GetUsersRequest : IRequest<IEnumerable<UserDto>>
{

}