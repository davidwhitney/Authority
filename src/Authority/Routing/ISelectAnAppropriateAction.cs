namespace Authority.Routing
{
    public interface ISelectAnAppropriateAction
    {
        RoutingResult Route(string[] args);
    }
}
