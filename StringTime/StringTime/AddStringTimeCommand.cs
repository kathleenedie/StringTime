using MediatR;

namespace StringTime;

public class AddStringTimeCommand : IRequest<StringTime>
{
    public int Id { get; }
    public string Words { get; }

    public AddStringTimeCommand(int id, string words)
    {
        Id = id;
        Words = words;
    }

    public class AddStringTimeCommandHandler : IRequestHandler<AddStringTimeCommand, StringTime>
    {
        private readonly AppDbContext _context;

        public AddStringTimeCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<StringTime> Handle(AddStringTimeCommand request, CancellationToken ct)
        {
            var stringTime = new StringTime
            {
                Id = request.Id,
                Words = request.Words,
            };

            _context.StringTimes.Add(stringTime);
            await _context.SaveChangesAsync(ct);
            return stringTime;
        }
    }
}