using FluentValidation;

namespace StringTime;

public class AddStringTimeCommandValidator : AbstractValidator<AddStringTimeCommand>
{
    public AddStringTimeCommandValidator()
    {
        RuleFor(s => s.Id).NotEmpty();
        RuleFor(s => s.Words).MaximumLength(25);
    }
}