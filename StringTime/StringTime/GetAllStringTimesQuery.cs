using MediatR;
using Microsoft.EntityFrameworkCore;

namespace StringTime
{
    public class GetAllStringTimesQuery : IRequest<List<StringTime>>
    {
        public class GetAllStringTimesQueryHandler : IRequestHandler<GetAllStringTimesQuery, List<StringTime>>
        {
            private readonly AppDbContext _context;

            public GetAllStringTimesQueryHandler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<List<StringTime>> Handle(GetAllStringTimesQuery request, CancellationToken ct)
            {
                var stringtimes = await _context.StringTimes.ToListAsync(ct);
                return stringtimes;
            }
        }
    }
}
