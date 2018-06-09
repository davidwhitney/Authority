namespace Authority.ControlFlow
{
    public class TextResult : ActionResult<string>
    {
        public TextResult(string value, bool includeTrailingNewLine = true, int? exitCode = null) 
            : base(value, includeTrailingNewLine, exitCode)
        {
        }
    }
}