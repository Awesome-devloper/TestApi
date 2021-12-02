using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpGet(Name = "AddSomeValue")]
        public ActionResult<int> GetData([FromQuery] int num1, [FromQuery] int num2)
        {
            var result = num1+num2;
            return result;
        }
    }
}
