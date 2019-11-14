using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace expt_20191114.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetTaskAsync()
        {
            await Task.Run(() => {});
            return Ok();
        }

        [HttpGet("value")]
        public async Task<IActionResult> GetTaskAsync([FromQuery] string value)
        {
            await Task.Run(() => {});
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> PostTaskAsync([FromBody] string value)
        {
            await Task.Run(() => {});
            return Ok(value);
        }

        [HttpPost("list")]
        public async Task<IActionResult> PostTaskAsync([FromBody] string[] values)
        {
            await Task.Run(() => {});
            return Ok(values);
        }

        [HttpPost("list2")]
        public async Task<IActionResult> PostTaskAsync([FromBody] ParamClass values)
        {
            await Task.Run(() => {});
            return Ok(values);
        }
    }

    public class ParamClass
    {
        public string[] Textvalues { get; set; }
    }
}