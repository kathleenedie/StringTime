using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StringTime.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class StringTimeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ISender _mediator;

        public StringTimeController(AppDbContext context, ISender mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllStringTimes")]
        public async Task<IActionResult> GetAllStringTimes()
        {
            var stringtimes = await _mediator.Send(new GetAllStringTimesQuery());
            return Ok(stringtimes);

            //public async Task<List<StringTime>> GetAllWordStrings()
            //{
            //    return await _context.StringTimes.ToListAsync();
            //}
        }

        [HttpPost("{id}/{words}", Name = "PostWordStrings")]
        public async Task<IActionResult> AddStringTime([FromRoute] int id, [FromRoute] string words)
        {
            var stringtime = await _mediator.Send(new AddStringTimeCommand(id, words));
            return Ok(stringtime);
        }
    }
}