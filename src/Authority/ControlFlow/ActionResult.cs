using System;

namespace Authority.ControlFlow
{
    public class ActionResult<T> : ActionResultBase
    {
        public T Value { get; }
        public bool IncludeTrailingNewLine { get; }

        public ActionResult(T value, bool includeTrailingNewLine = true, int? exitCode = null)
        {
            Value = value;
            IncludeTrailingNewLine = includeTrailingNewLine;
            ExitCode = exitCode;
        }

        protected override void Invoke()
        {
            if (IncludeTrailingNewLine)
            {
                Console.WriteLine(Value);
            }
            else
            {
                Console.Write(Value);
            }
        }
    }
}