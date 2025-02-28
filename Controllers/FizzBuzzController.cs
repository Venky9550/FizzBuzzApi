using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly FizzBuzzService _service;

        public FizzBuzzController(FizzBuzzService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<IEnumerable<string>> Post(int[] numbers)
        {
            if (numbers == null)
            {
                return BadRequest("Input array cannot be null.");
            }

            var results = numbers.Select(n => _service.GetFizzBuzz(n)).ToList();
            return results;
        }

        [HttpGet("divisions")]
        public ActionResult<DivisionCounter> GetDivisions()
        {
            return _service.GetDivisionCounter();
        }
    }
}

