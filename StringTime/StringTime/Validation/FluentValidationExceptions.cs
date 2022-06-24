namespace StringTime.Validation
{
    public class FluentValidationExceptions : Exception
    {
        public IReadOnlyDictionary<string, string[]> Errors { get; }

        public FluentValidationExceptions(IReadOnlyDictionary<string, string[]> errors) : base(
            "One or more errors have occurred")
            => Errors = errors;
    }
}
