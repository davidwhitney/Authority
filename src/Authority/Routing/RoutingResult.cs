using System;
using System.Reflection;

namespace Authority.Routing
{
    public class RoutingResult
    {
        public Type TargetType { get; set; }
        public MethodInfo TargetMethod { get; set; }
    }
}