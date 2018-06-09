using System.Collections.Generic;
using Authority.ControlFlow;

namespace Authority
{
    public class CommandLineApplication
    {
        private readonly AuthorityConfiguration _configuration;

        public CommandLineApplication(AuthorityConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Run(string[] args)
        {
            var callContext = new CallContext(args);

            var routingResult = _configuration.RoutingStrategy.Route(args);

            var action = _configuration.TypeActivationStrategy.CreateType(routingResult.TargetType);
            var arguments = new List<object>();
            var result = routingResult.TargetMethod.Invoke(action, arguments.ToArray()) as ActionResultBase;

            result.Invoke();

            
        }
    }
}