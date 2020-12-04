using Gatekeeper.SCIM.Client.Schema.Core20;

namespace Gatekeeper.SCIM.Client.Result
{
    public class CreateUserResult : IResult
    {
        public StateEnum ResultStatus { get; set; }
        public User? User { get; set; }
    }
}
