using System.Collections.Generic;
using Authority.ControlFlow;

namespace Authority
{
    public class CallContext
    {
        public string[] Args { get; }
        public List<ActionResultBase> ResultHistory { get; } = new List<ActionResultBase>();

        public CallContext(string[] args)
        {
            Args = args;
        }
    }
}