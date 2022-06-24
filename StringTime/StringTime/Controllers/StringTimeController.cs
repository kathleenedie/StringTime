using Microsoft.AspNetCore.Mvc;

namespace StringTime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringTimeController : ControllerBase
    {
        private static readonly string[] WordStrings = new[]
        {
        "Paris", "Barcelona", "Bangkok", "Larnica", "Algiers"
    };

        private readonly ILogger<StringTimeController> _logger;

        public StringTimeController(ILogger<StringTimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWordStrings")]
        public IEnumerable<StringTime> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new StringTime
            {
                Number = index,
                Words = WordStrings[Random.Shared.Next(WordStrings.Length)]
            })
            .ToArray();
        }
    }
}