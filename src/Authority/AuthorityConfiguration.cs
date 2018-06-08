using System;
using Authority.Infrastructure;
using Authority.Routing;

namespace Authority
{
    public class AuthorityConfiguration
    {
        public IActivateTypes TypeActivationStrategy { get; set; }
        public ISelectAnAppropriateAction RoutingStrategy { get; set; }

        public AuthorityConfiguration()
        {
            RoutingStrategy = null;
            TypeActivationStrategy = new TypeCreationFunctionWrapper(Activator.CreateInstance);
        }

        public CommandLineApplication ConfiguredApplication()
        {
            return new CommandLineApplication(this);
        }

        public static AuthorityConfiguration Default() => new AuthorityConfiguration();
    }
}
