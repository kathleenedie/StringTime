using FluentValidation;

namespace StringTime;

public class StringTimeValidator : AbstractValidator<StringTime>
{
    public StringTimeValidator()
    {
        RuleFor(s => s.Id).NotEmpty();
        RuleFor(s => s.Words).MaximumLength(25);
    }
}