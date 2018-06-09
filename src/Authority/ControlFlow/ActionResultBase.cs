using System.Collections.Generic;
using System.Text;

namespace Authority.ControlFlow
{
    public abstract class ActionResultBase
    {
        public int? ExitCode { get; set; }
        public abstract void Invoke();
    }
}
