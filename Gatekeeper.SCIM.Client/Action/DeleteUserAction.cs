namespace Gatekeeper.SCIM.Client.Action
{
    public class DeleteUserAction : IAction
    {
        internal readonly string Id;

        public DeleteUserAction(string id)
        {
            Id = id;
        }
    }
}
