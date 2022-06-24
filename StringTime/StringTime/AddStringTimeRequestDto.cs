using FluentValidation;
using StringTime.Commands;

namespace StringTime
{
    public class AddStringTimeRequestDto
    {
        public int Id { get; set; }
        public string Words { get; set; }
    }

    public class StringTimeValidator : AbstractValidator<AddStringTimeRequestDto>
    {
        public StringTimeValidator()
        {
            RuleFor(s => s.Id).NotEmpty();
            RuleFor(s => s.Words).MaximumLength(25);
        }
    }
}
