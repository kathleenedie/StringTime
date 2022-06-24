using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StringTime.Commands;
using StringTime.Query;

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
        }

        [HttpPost(Name = "PostWordStrings")]
        public async Task<IActionResult> AddStringTime([FromBody] AddStringTimeRequestDto model)
        {
            var stringtime = await _mediator.Send(new AddStringTimeCommand(model.Id, model.Words));
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }
            return Ok(stringtime);
        }
    }
}