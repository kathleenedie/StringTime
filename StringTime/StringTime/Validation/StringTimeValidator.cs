using FluentValidation;
using StringTime.Commands;

namespace StringTime.Validation;

public class StringTimeValidator : AbstractValidator<AddStringTimeCommand>
{
    public StringTimeValidator()
    {
        RuleFor(s => s.Id).NotEmpty();
        RuleFor(s => s.Words).MaximumLength(25);
    }
}